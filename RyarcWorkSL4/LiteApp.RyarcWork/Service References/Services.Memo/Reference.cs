﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace LiteApp.RyarcWork.Services.Memo {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Memo", Namespace="http://schemas.datacontract.org/2004/07/LiteApp.RyarcWork.Web.Entities")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LiteApp.RyarcWork.Services.Memo.ObjectId))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.BsonElement>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LiteApp.RyarcWork.Services.Memo.BsonElement))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LiteApp.RyarcWork.Services.Memo.BsonValue))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LiteApp.RyarcWork.Services.Memo.BsonType))]
    public partial class Memo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private LiteApp.RyarcWork.Services.Memo.ObjectId IdField;
        
        private object KeysField;
        
        private System.DateTime LastModifiedDateField;
        
        private string NameField;
        
        private System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.BsonElement> ValuesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LiteApp.RyarcWork.Services.Memo.ObjectId Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Keys {
            get {
                return this.KeysField;
            }
            set {
                if ((object.ReferenceEquals(this.KeysField, value) != true)) {
                    this.KeysField = value;
                    this.RaisePropertyChanged("Keys");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastModifiedDate {
            get {
                return this.LastModifiedDateField;
            }
            set {
                if ((this.LastModifiedDateField.Equals(value) != true)) {
                    this.LastModifiedDateField = value;
                    this.RaisePropertyChanged("LastModifiedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.BsonElement> Values {
            get {
                return this.ValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.ValuesField, value) != true)) {
                    this.ValuesField = value;
                    this.RaisePropertyChanged("Values");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectId", Namespace="http://schemas.datacontract.org/2004/07/MongoDB.Bson")]
    public partial struct ObjectId : System.ComponentModel.INotifyPropertyChanged {
        
        private int _incrementField;
        
        private int _machineField;
        
        private short _pidField;
        
        private int _timestampField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _increment {
            get {
                return this._incrementField;
            }
            set {
                if ((this._incrementField.Equals(value) != true)) {
                    this._incrementField = value;
                    this.RaisePropertyChanged("_increment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _machine {
            get {
                return this._machineField;
            }
            set {
                if ((this._machineField.Equals(value) != true)) {
                    this._machineField = value;
                    this.RaisePropertyChanged("_machine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short _pid {
            get {
                return this._pidField;
            }
            set {
                if ((this._pidField.Equals(value) != true)) {
                    this._pidField = value;
                    this.RaisePropertyChanged("_pid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _timestamp {
            get {
                return this._timestampField;
            }
            set {
                if ((this._timestampField.Equals(value) != true)) {
                    this._timestampField = value;
                    this.RaisePropertyChanged("_timestamp");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BsonElement", Namespace="http://schemas.datacontract.org/2004/07/MongoDB.Bson")]
    public partial class BsonElement : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string _nameField;
        
        private LiteApp.RyarcWork.Services.Memo.BsonValue _valueField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string _name {
            get {
                return this._nameField;
            }
            set {
                if ((object.ReferenceEquals(this._nameField, value) != true)) {
                    this._nameField = value;
                    this.RaisePropertyChanged("_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public LiteApp.RyarcWork.Services.Memo.BsonValue _value {
            get {
                return this._valueField;
            }
            set {
                if ((object.ReferenceEquals(this._valueField, value) != true)) {
                    this._valueField = value;
                    this.RaisePropertyChanged("_value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BsonValue", Namespace="http://schemas.datacontract.org/2004/07/MongoDB.Bson")]
    public partial class BsonValue : object, System.ComponentModel.INotifyPropertyChanged {
        
        private LiteApp.RyarcWork.Services.Memo.BsonType _bsonTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public LiteApp.RyarcWork.Services.Memo.BsonType _bsonType {
            get {
                return this._bsonTypeField;
            }
            set {
                if ((this._bsonTypeField.Equals(value) != true)) {
                    this._bsonTypeField = value;
                    this.RaisePropertyChanged("_bsonType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BsonType", Namespace="http://schemas.datacontract.org/2004/07/MongoDB.Bson")]
    public enum BsonType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EndOfDocument = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Double = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        String = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Document = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Array = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Binary = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Undefined = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ObjectId = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Boolean = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DateTime = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Null = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RegularExpression = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        JavaScript = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Symbol = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        JavaScriptWithScope = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Int32 = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Timestamp = 17,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Int64 = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MinKey = 255,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MaxKey = 127,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="Services.Memo.MemoService")]
    public interface MemoService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:MemoService/GetMemos", ReplyAction="urn:MemoService/GetMemosResponse")]
        System.IAsyncResult BeginGetMemos(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo> EndGetMemos(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MemoServiceChannel : LiteApp.RyarcWork.Services.Memo.MemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetMemosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetMemosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MemoServiceClient : System.ServiceModel.ClientBase<LiteApp.RyarcWork.Services.Memo.MemoService>, LiteApp.RyarcWork.Services.Memo.MemoService {
        
        private BeginOperationDelegate onBeginGetMemosDelegate;
        
        private EndOperationDelegate onEndGetMemosDelegate;
        
        private System.Threading.SendOrPostCallback onGetMemosCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public MemoServiceClient() {
        }
        
        public MemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetMemosCompletedEventArgs> GetMemosCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult LiteApp.RyarcWork.Services.Memo.MemoService.BeginGetMemos(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetMemos(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo> LiteApp.RyarcWork.Services.Memo.MemoService.EndGetMemos(System.IAsyncResult result) {
            return base.Channel.EndGetMemos(result);
        }
        
        private System.IAsyncResult OnBeginGetMemos(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((LiteApp.RyarcWork.Services.Memo.MemoService)(this)).BeginGetMemos(callback, asyncState);
        }
        
        private object[] OnEndGetMemos(System.IAsyncResult result) {
            System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo> retVal = ((LiteApp.RyarcWork.Services.Memo.MemoService)(this)).EndGetMemos(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetMemosCompleted(object state) {
            if ((this.GetMemosCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetMemosCompleted(this, new GetMemosCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetMemosAsync() {
            this.GetMemosAsync(null);
        }
        
        public void GetMemosAsync(object userState) {
            if ((this.onBeginGetMemosDelegate == null)) {
                this.onBeginGetMemosDelegate = new BeginOperationDelegate(this.OnBeginGetMemos);
            }
            if ((this.onEndGetMemosDelegate == null)) {
                this.onEndGetMemosDelegate = new EndOperationDelegate(this.OnEndGetMemos);
            }
            if ((this.onGetMemosCompletedDelegate == null)) {
                this.onGetMemosCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetMemosCompleted);
            }
            base.InvokeAsync(this.onBeginGetMemosDelegate, null, this.onEndGetMemosDelegate, this.onGetMemosCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override LiteApp.RyarcWork.Services.Memo.MemoService CreateChannel() {
            return new MemoServiceClientChannel(this);
        }
        
        private class MemoServiceClientChannel : ChannelBase<LiteApp.RyarcWork.Services.Memo.MemoService>, LiteApp.RyarcWork.Services.Memo.MemoService {
            
            public MemoServiceClientChannel(System.ServiceModel.ClientBase<LiteApp.RyarcWork.Services.Memo.MemoService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetMemos(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetMemos", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo> EndGetMemos(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo> _result = ((System.Collections.Generic.List<LiteApp.RyarcWork.Services.Memo.Memo>)(base.EndInvoke("GetMemos", _args, result)));
                return _result;
            }
        }
    }
}
