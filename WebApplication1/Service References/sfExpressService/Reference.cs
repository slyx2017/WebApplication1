﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.sfExpressService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.expressservice.integration.sf.com/", ConfigurationName="sfExpressService.IExpressService")]
    public interface IExpressService {
        
        // CODEGEN: 命名空间  的元素名称 arg0 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        WebApplication1.sfExpressService.sfexpressServiceResponse sfexpressService(WebApplication1.sfExpressService.sfexpressService request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.sfExpressService.sfexpressServiceResponse> sfexpressServiceAsync(WebApplication1.sfExpressService.sfexpressService request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sfexpressService {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sfexpressService", Namespace="http://service.expressservice.integration.sf.com/", Order=0)]
        public WebApplication1.sfExpressService.sfexpressServiceBody Body;
        
        public sfexpressService() {
        }
        
        public sfexpressService(WebApplication1.sfExpressService.sfexpressServiceBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class sfexpressServiceBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string arg1;
        
        public sfexpressServiceBody() {
        }
        
        public sfexpressServiceBody(string arg0, string arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sfexpressServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sfexpressServiceResponse", Namespace="http://service.expressservice.integration.sf.com/", Order=0)]
        public WebApplication1.sfExpressService.sfexpressServiceResponseBody Body;
        
        public sfexpressServiceResponse() {
        }
        
        public sfexpressServiceResponse(WebApplication1.sfExpressService.sfexpressServiceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class sfexpressServiceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public sfexpressServiceResponseBody() {
        }
        
        public sfexpressServiceResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExpressServiceChannel : WebApplication1.sfExpressService.IExpressService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExpressServiceClient : System.ServiceModel.ClientBase<WebApplication1.sfExpressService.IExpressService>, WebApplication1.sfExpressService.IExpressService {
        
        public ExpressServiceClient() {
        }
        
        public ExpressServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExpressServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExpressServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExpressServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.sfExpressService.sfexpressServiceResponse WebApplication1.sfExpressService.IExpressService.sfexpressService(WebApplication1.sfExpressService.sfexpressService request) {
            return base.Channel.sfexpressService(request);
        }
        
        public string sfexpressService(string arg0, string arg1) {
            WebApplication1.sfExpressService.sfexpressService inValue = new WebApplication1.sfExpressService.sfexpressService();
            inValue.Body = new WebApplication1.sfExpressService.sfexpressServiceBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            WebApplication1.sfExpressService.sfexpressServiceResponse retVal = ((WebApplication1.sfExpressService.IExpressService)(this)).sfexpressService(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.sfExpressService.sfexpressServiceResponse> WebApplication1.sfExpressService.IExpressService.sfexpressServiceAsync(WebApplication1.sfExpressService.sfexpressService request) {
            return base.Channel.sfexpressServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.sfExpressService.sfexpressServiceResponse> sfexpressServiceAsync(string arg0, string arg1) {
            WebApplication1.sfExpressService.sfexpressService inValue = new WebApplication1.sfExpressService.sfexpressService();
            inValue.Body = new WebApplication1.sfExpressService.sfexpressServiceBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            return ((WebApplication1.sfExpressService.IExpressService)(this)).sfexpressServiceAsync(inValue);
        }
    }
}
