using System;
using System.Collections.Generic;
using System.Reflection;

namespace LiteApp.RyarcWork.ViewModels.Validation
{
    public abstract class ValidatorBase : IValidator
    {
        readonly Dictionary<string, string> Errors;
        object _target;
        Dictionary<string, MethodInfo> _propertyGetters;

        public object Target 
        {
            get { return _target; }
            set
            {
                if (_target != value)
                {
                    _target = value;
                    _propertyGetters = null; // Reset this to null to enforce reload next time
                }
            }
        }

        public ValidatorBase()
        {
            Errors = new Dictionary<string, string>();
        }

        public void AddError(string propertyName, string message)
        {
            if (!Errors.ContainsKey(propertyName))
            {
                Errors[propertyName] = message;
            }
            else
            {
                throw new ArgumentException("propertyName already exists in errors dictionary.");
            }
        }

        public void RemoveError(string propertyName)
        {
            Errors.Remove(propertyName);
        }

        public string GetPropertyErrorMessage(string propertyName)
        {
            string message = string.Empty;
            Errors.TryGetValue(propertyName, out message);
            return message;
            
        }

        public bool HasErrors
        {
            get { return Errors.Count != 0; }
        }

        public string ValidateProperty(string propertyName)
        {
            if (_propertyGetters == null)
                LoadValidationRequiredProperties();
            MethodInfo getter = null;
            if (_propertyGetters.TryGetValue(propertyName, out getter))
            {
                var value = getter.Invoke(Target, new object[] { });
                return ValidateProperty(propertyName, value);
            }
            return string.Empty;
        }

        protected virtual string ValidateProperty(string propertyName, object value)
        {
            return string.Empty;
        }

        void LoadValidationRequiredProperties()
        {
            _propertyGetters = new Dictionary<string, MethodInfo>();
            if (Target != null)
            {
                foreach (var propInfo in Target.GetType().GetProperties())
                {
                    if (IsValidateRequrired(propInfo))
                    {
                        var getMethod = propInfo.GetGetMethod();
                        if (getMethod == null)
                            throw new Exception(string.Format("Get method is null while this property [{0}] has Validate attribute", propInfo.Name));
                        _propertyGetters[propInfo.Name] = getMethod;
                    }
                }
            }
        }

        private static bool IsValidateRequrired(PropertyInfo propInfo)
        {
            foreach (var attr in propInfo.GetCustomAttributes(true))
            {
                if (attr is ValidationRequiredAttribute)
                    return true;
            }
            return false;
        }
    }
}
