﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NumericValueToWord.Tests.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.NumericValueToWordSoap")]
    public interface NumericValueToWordSoap {
        
        // CODEGEN: Generating message contract since element name dollarNumber from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertNumericValueToWord", ReplyAction="*")]
        NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordResponse ConvertNumericValueToWord(NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertNumericValueToWord", ReplyAction="*")]
        System.Threading.Tasks.Task<NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordResponse> ConvertNumericValueToWordAsync(NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertNumericValueToWordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertNumericValueToWord", Namespace="http://tempuri.org/", Order=0)]
        public NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequestBody Body;
        
        public ConvertNumericValueToWordRequest() {
        }
        
        public ConvertNumericValueToWordRequest(NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertNumericValueToWordRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string dollarNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string centNumber;
        
        public ConvertNumericValueToWordRequestBody() {
        }
        
        public ConvertNumericValueToWordRequestBody(string dollarNumber, string name, string centNumber) {
            this.dollarNumber = dollarNumber;
            this.name = name;
            this.centNumber = centNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertNumericValueToWordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertNumericValueToWordResponse", Namespace="http://tempuri.org/", Order=0)]
        public NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordResponseBody Body;
        
        public ConvertNumericValueToWordResponse() {
        }
        
        public ConvertNumericValueToWordResponse(NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertNumericValueToWordResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConvertNumericValueToWordResult;
        
        public ConvertNumericValueToWordResponseBody() {
        }
        
        public ConvertNumericValueToWordResponseBody(string ConvertNumericValueToWordResult) {
            this.ConvertNumericValueToWordResult = ConvertNumericValueToWordResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NumericValueToWordSoapChannel : NumericValueToWord.Tests.ServiceReference.NumericValueToWordSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NumericValueToWordSoapClient : System.ServiceModel.ClientBase<NumericValueToWord.Tests.ServiceReference.NumericValueToWordSoap>, NumericValueToWord.Tests.ServiceReference.NumericValueToWordSoap {
        
        public NumericValueToWordSoapClient() {
        }
        
        public NumericValueToWordSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NumericValueToWordSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumericValueToWordSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumericValueToWordSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordResponse NumericValueToWord.Tests.ServiceReference.NumericValueToWordSoap.ConvertNumericValueToWord(NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequest request) {
            return base.Channel.ConvertNumericValueToWord(request);
        }
        
        public string ConvertNumericValueToWord(string dollarNumber, string name, string centNumber) {
            NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequest inValue = new NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequest();
            inValue.Body = new NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequestBody();
            inValue.Body.dollarNumber = dollarNumber;
            inValue.Body.name = name;
            inValue.Body.centNumber = centNumber;
            NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordResponse retVal = ((NumericValueToWord.Tests.ServiceReference.NumericValueToWordSoap)(this)).ConvertNumericValueToWord(inValue);
            return retVal.Body.ConvertNumericValueToWordResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordResponse> NumericValueToWord.Tests.ServiceReference.NumericValueToWordSoap.ConvertNumericValueToWordAsync(NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequest request) {
            return base.Channel.ConvertNumericValueToWordAsync(request);
        }
        
        public System.Threading.Tasks.Task<NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordResponse> ConvertNumericValueToWordAsync(string dollarNumber, string name, string centNumber) {
            NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequest inValue = new NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequest();
            inValue.Body = new NumericValueToWord.Tests.ServiceReference.ConvertNumericValueToWordRequestBody();
            inValue.Body.dollarNumber = dollarNumber;
            inValue.Body.name = name;
            inValue.Body.centNumber = centNumber;
            return ((NumericValueToWord.Tests.ServiceReference.NumericValueToWordSoap)(this)).ConvertNumericValueToWordAsync(inValue);
        }
    }
}
