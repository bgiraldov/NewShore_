﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBAPP.ServiceReferenceWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceWCF.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EsCliente", ReplyAction="http://tempuri.org/IService/EsClienteResponse")]
        bool EsCliente(string contenido, string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EsCliente", ReplyAction="http://tempuri.org/IService/EsClienteResponse")]
        System.Threading.Tasks.Task<bool> EsClienteAsync(string contenido, string nombre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WEBAPP.ServiceReferenceWCF.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WEBAPP.ServiceReferenceWCF.IService>, WEBAPP.ServiceReferenceWCF.IService {
        
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
        
        public bool EsCliente(string contenido, string nombre) {
            return base.Channel.EsCliente(contenido, nombre);
        }
        
        public System.Threading.Tasks.Task<bool> EsClienteAsync(string contenido, string nombre) {
            return base.Channel.EsClienteAsync(contenido, nombre);
        }
    }
}
