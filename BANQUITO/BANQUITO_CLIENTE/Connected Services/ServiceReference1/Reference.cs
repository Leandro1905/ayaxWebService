﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebApplication1.ServiceReference1.HelloWorldResponse HelloWorld(WebApplication1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebApplication1.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SoyLindo", ReplyAction="*")]
        WebApplication1.ServiceReference1.SoyLindoResponse SoyLindo(WebApplication1.ServiceReference1.SoyLindoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SoyLindo", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.SoyLindoResponse> SoyLindoAsync(WebApplication1.ServiceReference1.SoyLindoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento fecha del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValorDelVerde", ReplyAction="*")]
        WebApplication1.ServiceReference1.ValorDelVerdeResponse ValorDelVerde(WebApplication1.ServiceReference1.ValorDelVerdeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValorDelVerde", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.ValorDelVerdeResponse> ValorDelVerdeAsync(WebApplication1.ServiceReference1.ValorDelVerdeRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento fecha del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PasoFecha", ReplyAction="*")]
        WebApplication1.ServiceReference1.PasoFechaResponse PasoFecha(WebApplication1.ServiceReference1.PasoFechaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PasoFecha", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.PasoFechaResponse> PasoFechaAsync(WebApplication1.ServiceReference1.PasoFechaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApplication1.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApplication1.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SoyLindoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SoyLindo", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.SoyLindoRequestBody Body;
        
        public SoyLindoRequest() {
        }
        
        public SoyLindoRequest(WebApplication1.ServiceReference1.SoyLindoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SoyLindoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public SoyLindoRequestBody() {
        }
        
        public SoyLindoRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SoyLindoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SoyLindoResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.SoyLindoResponseBody Body;
        
        public SoyLindoResponse() {
        }
        
        public SoyLindoResponse(WebApplication1.ServiceReference1.SoyLindoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SoyLindoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SoyLindoResult;
        
        public SoyLindoResponseBody() {
        }
        
        public SoyLindoResponseBody(string SoyLindoResult) {
            this.SoyLindoResult = SoyLindoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValorDelVerdeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValorDelVerde", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.ValorDelVerdeRequestBody Body;
        
        public ValorDelVerdeRequest() {
        }
        
        public ValorDelVerdeRequest(WebApplication1.ServiceReference1.ValorDelVerdeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValorDelVerdeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fecha;
        
        public ValorDelVerdeRequestBody() {
        }
        
        public ValorDelVerdeRequestBody(string fecha) {
            this.fecha = fecha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValorDelVerdeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValorDelVerdeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.ValorDelVerdeResponseBody Body;
        
        public ValorDelVerdeResponse() {
        }
        
        public ValorDelVerdeResponse(WebApplication1.ServiceReference1.ValorDelVerdeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValorDelVerdeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public decimal ValorDelVerdeResult;
        
        public ValorDelVerdeResponseBody() {
        }
        
        public ValorDelVerdeResponseBody(decimal ValorDelVerdeResult) {
            this.ValorDelVerdeResult = ValorDelVerdeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PasoFechaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PasoFecha", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.PasoFechaRequestBody Body;
        
        public PasoFechaRequest() {
        }
        
        public PasoFechaRequest(WebApplication1.ServiceReference1.PasoFechaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PasoFechaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fecha;
        
        public PasoFechaRequestBody() {
        }
        
        public PasoFechaRequestBody(string fecha) {
            this.fecha = fecha;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PasoFechaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PasoFechaResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.ServiceReference1.PasoFechaResponseBody Body;
        
        public PasoFechaResponse() {
        }
        
        public PasoFechaResponse(WebApplication1.ServiceReference1.PasoFechaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PasoFechaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PasoFechaResult;
        
        public PasoFechaResponseBody() {
        }
        
        public PasoFechaResponseBody(string PasoFechaResult) {
            this.PasoFechaResult = PasoFechaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebApplication1.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.WebService1Soap>, WebApplication1.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.HelloWorldResponse WebApplication1.ServiceReference1.WebService1Soap.HelloWorld(WebApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebApplication1.ServiceReference1.HelloWorldRequest inValue = new WebApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplication1.ServiceReference1.HelloWorldRequestBody();
            WebApplication1.ServiceReference1.HelloWorldResponse retVal = ((WebApplication1.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.HelloWorldResponse> WebApplication1.ServiceReference1.WebService1Soap.HelloWorldAsync(WebApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebApplication1.ServiceReference1.HelloWorldRequest inValue = new WebApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplication1.ServiceReference1.HelloWorldRequestBody();
            return ((WebApplication1.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.SoyLindoResponse WebApplication1.ServiceReference1.WebService1Soap.SoyLindo(WebApplication1.ServiceReference1.SoyLindoRequest request) {
            return base.Channel.SoyLindo(request);
        }
        
        public string SoyLindo(string nombre) {
            WebApplication1.ServiceReference1.SoyLindoRequest inValue = new WebApplication1.ServiceReference1.SoyLindoRequest();
            inValue.Body = new WebApplication1.ServiceReference1.SoyLindoRequestBody();
            inValue.Body.nombre = nombre;
            WebApplication1.ServiceReference1.SoyLindoResponse retVal = ((WebApplication1.ServiceReference1.WebService1Soap)(this)).SoyLindo(inValue);
            return retVal.Body.SoyLindoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.SoyLindoResponse> WebApplication1.ServiceReference1.WebService1Soap.SoyLindoAsync(WebApplication1.ServiceReference1.SoyLindoRequest request) {
            return base.Channel.SoyLindoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.SoyLindoResponse> SoyLindoAsync(string nombre) {
            WebApplication1.ServiceReference1.SoyLindoRequest inValue = new WebApplication1.ServiceReference1.SoyLindoRequest();
            inValue.Body = new WebApplication1.ServiceReference1.SoyLindoRequestBody();
            inValue.Body.nombre = nombre;
            return ((WebApplication1.ServiceReference1.WebService1Soap)(this)).SoyLindoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.ValorDelVerdeResponse WebApplication1.ServiceReference1.WebService1Soap.ValorDelVerde(WebApplication1.ServiceReference1.ValorDelVerdeRequest request) {
            return base.Channel.ValorDelVerde(request);
        }
        
        public decimal ValorDelVerde(string fecha) {
            WebApplication1.ServiceReference1.ValorDelVerdeRequest inValue = new WebApplication1.ServiceReference1.ValorDelVerdeRequest();
            inValue.Body = new WebApplication1.ServiceReference1.ValorDelVerdeRequestBody();
            inValue.Body.fecha = fecha;
            WebApplication1.ServiceReference1.ValorDelVerdeResponse retVal = ((WebApplication1.ServiceReference1.WebService1Soap)(this)).ValorDelVerde(inValue);
            return retVal.Body.ValorDelVerdeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.ValorDelVerdeResponse> WebApplication1.ServiceReference1.WebService1Soap.ValorDelVerdeAsync(WebApplication1.ServiceReference1.ValorDelVerdeRequest request) {
            return base.Channel.ValorDelVerdeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.ValorDelVerdeResponse> ValorDelVerdeAsync(string fecha) {
            WebApplication1.ServiceReference1.ValorDelVerdeRequest inValue = new WebApplication1.ServiceReference1.ValorDelVerdeRequest();
            inValue.Body = new WebApplication1.ServiceReference1.ValorDelVerdeRequestBody();
            inValue.Body.fecha = fecha;
            return ((WebApplication1.ServiceReference1.WebService1Soap)(this)).ValorDelVerdeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.PasoFechaResponse WebApplication1.ServiceReference1.WebService1Soap.PasoFecha(WebApplication1.ServiceReference1.PasoFechaRequest request) {
            return base.Channel.PasoFecha(request);
        }
        
        public string PasoFecha(string fecha) {
            WebApplication1.ServiceReference1.PasoFechaRequest inValue = new WebApplication1.ServiceReference1.PasoFechaRequest();
            inValue.Body = new WebApplication1.ServiceReference1.PasoFechaRequestBody();
            inValue.Body.fecha = fecha;
            WebApplication1.ServiceReference1.PasoFechaResponse retVal = ((WebApplication1.ServiceReference1.WebService1Soap)(this)).PasoFecha(inValue);
            return retVal.Body.PasoFechaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.ServiceReference1.PasoFechaResponse> WebApplication1.ServiceReference1.WebService1Soap.PasoFechaAsync(WebApplication1.ServiceReference1.PasoFechaRequest request) {
            return base.Channel.PasoFechaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.ServiceReference1.PasoFechaResponse> PasoFechaAsync(string fecha) {
            WebApplication1.ServiceReference1.PasoFechaRequest inValue = new WebApplication1.ServiceReference1.PasoFechaRequest();
            inValue.Body = new WebApplication1.ServiceReference1.PasoFechaRequestBody();
            inValue.Body.fecha = fecha;
            return ((WebApplication1.ServiceReference1.WebService1Soap)(this)).PasoFechaAsync(inValue);
        }
    }
}
