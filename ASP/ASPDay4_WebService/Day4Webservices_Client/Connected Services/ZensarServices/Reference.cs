//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Day4Webservices_Client.ZensarServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ZensarServices.MyWebService1Soap")]
    public interface MyWebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Day4Webservices_Client.ZensarServices.HelloWorldResponse HelloWorld(Day4Webservices_Client.ZensarServices.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Day4Webservices_Client.ZensarServices.HelloWorldResponse> HelloWorldAsync(Day4Webservices_Client.ZensarServices.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name str from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/msg", ReplyAction="*")]
        Day4Webservices_Client.ZensarServices.msgResponse msg(Day4Webservices_Client.ZensarServices.msgRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/msg", ReplyAction="*")]
        System.Threading.Tasks.Task<Day4Webservices_Client.ZensarServices.msgResponse> msgAsync(Day4Webservices_Client.ZensarServices.msgRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/findsquare", ReplyAction="*")]
        float findsquare(float num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/findsquare", ReplyAction="*")]
        System.Threading.Tasks.Task<float> findsquareAsync(float num);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Day4Webservices_Client.ZensarServices.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Day4Webservices_Client.ZensarServices.HelloWorldRequestBody Body) {
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
        public Day4Webservices_Client.ZensarServices.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Day4Webservices_Client.ZensarServices.HelloWorldResponseBody Body) {
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
    public partial class msgRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="msg", Namespace="http://tempuri.org/", Order=0)]
        public Day4Webservices_Client.ZensarServices.msgRequestBody Body;
        
        public msgRequest() {
        }
        
        public msgRequest(Day4Webservices_Client.ZensarServices.msgRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class msgRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string str;
        
        public msgRequestBody() {
        }
        
        public msgRequestBody(string str) {
            this.str = str;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class msgResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="msgResponse", Namespace="http://tempuri.org/", Order=0)]
        public Day4Webservices_Client.ZensarServices.msgResponseBody Body;
        
        public msgResponse() {
        }
        
        public msgResponse(Day4Webservices_Client.ZensarServices.msgResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class msgResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string msgResult;
        
        public msgResponseBody() {
        }
        
        public msgResponseBody(string msgResult) {
            this.msgResult = msgResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyWebService1SoapChannel : Day4Webservices_Client.ZensarServices.MyWebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyWebService1SoapClient : System.ServiceModel.ClientBase<Day4Webservices_Client.ZensarServices.MyWebService1Soap>, Day4Webservices_Client.ZensarServices.MyWebService1Soap {
        
        public MyWebService1SoapClient() {
        }
        
        public MyWebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyWebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyWebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Day4Webservices_Client.ZensarServices.HelloWorldResponse Day4Webservices_Client.ZensarServices.MyWebService1Soap.HelloWorld(Day4Webservices_Client.ZensarServices.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Day4Webservices_Client.ZensarServices.HelloWorldRequest inValue = new Day4Webservices_Client.ZensarServices.HelloWorldRequest();
            inValue.Body = new Day4Webservices_Client.ZensarServices.HelloWorldRequestBody();
            Day4Webservices_Client.ZensarServices.HelloWorldResponse retVal = ((Day4Webservices_Client.ZensarServices.MyWebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Day4Webservices_Client.ZensarServices.HelloWorldResponse> Day4Webservices_Client.ZensarServices.MyWebService1Soap.HelloWorldAsync(Day4Webservices_Client.ZensarServices.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Day4Webservices_Client.ZensarServices.HelloWorldResponse> HelloWorldAsync() {
            Day4Webservices_Client.ZensarServices.HelloWorldRequest inValue = new Day4Webservices_Client.ZensarServices.HelloWorldRequest();
            inValue.Body = new Day4Webservices_Client.ZensarServices.HelloWorldRequestBody();
            return ((Day4Webservices_Client.ZensarServices.MyWebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Day4Webservices_Client.ZensarServices.msgResponse Day4Webservices_Client.ZensarServices.MyWebService1Soap.msg(Day4Webservices_Client.ZensarServices.msgRequest request) {
            return base.Channel.msg(request);
        }
        
        public string msg(string str) {
            Day4Webservices_Client.ZensarServices.msgRequest inValue = new Day4Webservices_Client.ZensarServices.msgRequest();
            inValue.Body = new Day4Webservices_Client.ZensarServices.msgRequestBody();
            inValue.Body.str = str;
            Day4Webservices_Client.ZensarServices.msgResponse retVal = ((Day4Webservices_Client.ZensarServices.MyWebService1Soap)(this)).msg(inValue);
            return retVal.Body.msgResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Day4Webservices_Client.ZensarServices.msgResponse> Day4Webservices_Client.ZensarServices.MyWebService1Soap.msgAsync(Day4Webservices_Client.ZensarServices.msgRequest request) {
            return base.Channel.msgAsync(request);
        }
        
        public System.Threading.Tasks.Task<Day4Webservices_Client.ZensarServices.msgResponse> msgAsync(string str) {
            Day4Webservices_Client.ZensarServices.msgRequest inValue = new Day4Webservices_Client.ZensarServices.msgRequest();
            inValue.Body = new Day4Webservices_Client.ZensarServices.msgRequestBody();
            inValue.Body.str = str;
            return ((Day4Webservices_Client.ZensarServices.MyWebService1Soap)(this)).msgAsync(inValue);
        }
        
        public float findsquare(float num) {
            return base.Channel.findsquare(num);
        }
        
        public System.Threading.Tasks.Task<float> findsquareAsync(float num) {
            return base.Channel.findsquareAsync(num);
        }
    }
}
