﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanHang.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getTableProcedurce", ReplyAction="http://tempuri.org/IService/getTableProcedurceResponse")]
        System.Data.DataSet getTableProcedurce(string nameProcedure, System.Collections.Generic.Dictionary<string, object> values);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getTableProcedurce", ReplyAction="http://tempuri.org/IService/getTableProcedurceResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getTableProcedurceAsync(string nameProcedure, System.Collections.Generic.Dictionary<string, object> values);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getTable", ReplyAction="http://tempuri.org/IService/getTableResponse")]
        System.Data.DataSet getTable(string SQL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getTable", ReplyAction="http://tempuri.org/IService/getTableResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getTableAsync(string SQL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ExeCuteSQL", ReplyAction="http://tempuri.org/IService/ExeCuteSQLResponse")]
        int ExeCuteSQL(string SQL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ExeCuteSQL", ReplyAction="http://tempuri.org/IService/ExeCuteSQLResponse")]
        System.Threading.Tasks.Task<int> ExeCuteSQLAsync(string SQL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ExeCuteProcedurce", ReplyAction="http://tempuri.org/IService/ExeCuteProcedurceResponse")]
        int ExeCuteProcedurce(string nameProcedure, System.Collections.Generic.Dictionary<string, object> values);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ExeCuteProcedurce", ReplyAction="http://tempuri.org/IService/ExeCuteProcedurceResponse")]
        System.Threading.Tasks.Task<int> ExeCuteProcedurceAsync(string nameProcedure, System.Collections.Generic.Dictionary<string, object> values);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : BanHang.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<BanHang.ServiceReference1.IService>, BanHang.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet getTableProcedurce(string nameProcedure, System.Collections.Generic.Dictionary<string, object> values) {
            return base.Channel.getTableProcedurce(nameProcedure, values);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getTableProcedurceAsync(string nameProcedure, System.Collections.Generic.Dictionary<string, object> values) {
            return base.Channel.getTableProcedurceAsync(nameProcedure, values);
        }
        
        public System.Data.DataSet getTable(string SQL) {
            return base.Channel.getTable(SQL);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getTableAsync(string SQL) {
            return base.Channel.getTableAsync(SQL);
        }
        
        public int ExeCuteSQL(string SQL) {
            return base.Channel.ExeCuteSQL(SQL);
        }
        
        public System.Threading.Tasks.Task<int> ExeCuteSQLAsync(string SQL) {
            return base.Channel.ExeCuteSQLAsync(SQL);
        }
        
        public int ExeCuteProcedurce(string nameProcedure, System.Collections.Generic.Dictionary<string, object> values) {
            return base.Channel.ExeCuteProcedurce(nameProcedure, values);
        }
        
        public System.Threading.Tasks.Task<int> ExeCuteProcedurceAsync(string nameProcedure, System.Collections.Generic.Dictionary<string, object> values) {
            return base.Channel.ExeCuteProcedurceAsync(nameProcedure, values);
        }
    }
}
