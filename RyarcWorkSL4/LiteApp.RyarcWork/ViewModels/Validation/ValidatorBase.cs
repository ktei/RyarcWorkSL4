using System;
using System.Collections.Generic;
using System.Reflection;

namespace LiteApp.RyarcWork.ViewModels.Validation
{
    public abstract class ValidatorBase : IValidator
    {
        readonly Dictionary<string, string> Errors;

        public object Target { get; set; }

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

        public virtual void Validate()
        {
            if (Target != null)
            {
                foreach (var propInfo in Target.GetType().GetProperties())
                {
                    if (IsValidateRequrired(propInfo))
                    {
                        var getMethod = propInfo.GetGetMethod();
                        if (getMethod == null)
                            throw new Exception(string.Format("Get method is null while this property [{0}] has Validate attribute", propInfo.Name));
                        var value = getMethod.Invoke(Target, new object[] { });
                        var error = ValidateProperty(propInfo.Name, value);
                        if (!string.IsNullOrEmpty(error))
                            AddError(propInfo.Name, error);
                    }
                }
            }
        }

        protected virtual string ValidateProperty(string propertyName, object value)
        {
            return string.Empty;
        }

        private static bool IsValidateRequrired(PropertyInfo propInfo)
        {
            foreach (var attr in propInfo.GetCustomAttributes(true))
            {
                if (attr is ValidateRequiredAttribute)
                    return true;
            }
            return false;
        }
    }
}
