﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gobiner.SecureRepl.CommandLine.Wcf {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Wcf.IRepl")]
    public interface IRepl {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepl/Execute", ReplyAction="http://tempuri.org/IRepl/ExecuteResponse")]
        string Execute(string inp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepl/Execute", ReplyAction="http://tempuri.org/IRepl/ExecuteResponse")]
        System.Threading.Tasks.Task<string> ExecuteAsync(string inp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepl/Kill", ReplyAction="http://tempuri.org/IRepl/KillResponse")]
        void Kill();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepl/Kill", ReplyAction="http://tempuri.org/IRepl/KillResponse")]
        System.Threading.Tasks.Task KillAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepl/KeepAlive", ReplyAction="http://tempuri.org/IRepl/KeepAliveResponse")]
        void KeepAlive();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepl/KeepAlive", ReplyAction="http://tempuri.org/IRepl/KeepAliveResponse")]
        System.Threading.Tasks.Task KeepAliveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReplChannel : Gobiner.SecureRepl.CommandLine.Wcf.IRepl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReplClient : System.ServiceModel.ClientBase<Gobiner.SecureRepl.CommandLine.Wcf.IRepl>, Gobiner.SecureRepl.CommandLine.Wcf.IRepl {
        
        public ReplClient() {
        }
        
        public ReplClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReplClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReplClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReplClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Execute(string inp) {
            return base.Channel.Execute(inp);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteAsync(string inp) {
            return base.Channel.ExecuteAsync(inp);
        }
        
        public void Kill() {
            base.Channel.Kill();
        }
        
        public System.Threading.Tasks.Task KillAsync() {
            return base.Channel.KillAsync();
        }
        
        public void KeepAlive() {
            base.Channel.KeepAlive();
        }
        
        public System.Threading.Tasks.Task KeepAliveAsync() {
            return base.Channel.KeepAliveAsync();
        }
    }
}
