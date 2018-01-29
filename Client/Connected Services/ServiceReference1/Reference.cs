﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAktienInfo", CallbackContract=typeof(Client.ServiceReference1.IAktienInfoCallback))]
    public interface IAktienInfo {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/RegisterForUpdate")]
        void RegisterForUpdate(string username, string symbol);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/RegisterForUpdate")]
        System.Threading.Tasks.Task RegisterForUpdateAsync(string username, string symbol);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/getUsers")]
        void getUsers(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/getUsers")]
        System.Threading.Tasks.Task getUsersAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/getBooks")]
        void getBooks(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/getBooks")]
        System.Threading.Tasks.Task getBooksAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/getLogin")]
        void getLogin(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/getLogin")]
        System.Threading.Tasks.Task getLoginAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAktienInfoCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/BookUpdate")]
        void BookUpdate(string symbol, double preis, System.Data.DataSet ds);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/UpdateUsers")]
        void UpdateUsers(System.Data.DataSet ds);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/loginUser")]
        void loginUser(int status);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAktienInfo/loadBooks")]
        void loadBooks(System.Data.DataSet ds);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAktienInfoChannel : Client.ServiceReference1.IAktienInfo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AktienInfoClient : System.ServiceModel.DuplexClientBase<Client.ServiceReference1.IAktienInfo>, Client.ServiceReference1.IAktienInfo {
        
        public AktienInfoClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public AktienInfoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public AktienInfoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AktienInfoClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AktienInfoClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void RegisterForUpdate(string username, string symbol) {
            base.Channel.RegisterForUpdate(username, symbol);
        }
        
        public System.Threading.Tasks.Task RegisterForUpdateAsync(string username, string symbol) {
            return base.Channel.RegisterForUpdateAsync(username, symbol);
        }
        
        public void getUsers(string username) {
            base.Channel.getUsers(username);
        }
        
        public System.Threading.Tasks.Task getUsersAsync(string username) {
            return base.Channel.getUsersAsync(username);
        }
        
        public void getBooks(string username) {
            base.Channel.getBooks(username);
        }
        
        public System.Threading.Tasks.Task getBooksAsync(string username) {
            return base.Channel.getBooksAsync(username);
        }
        
        public void getLogin(string username, string password) {
            base.Channel.getLogin(username, password);
        }
        
        public System.Threading.Tasks.Task getLoginAsync(string username, string password) {
            return base.Channel.getLoginAsync(username, password);
        }
    }
}