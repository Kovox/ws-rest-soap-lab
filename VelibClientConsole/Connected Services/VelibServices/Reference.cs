﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VelibClientConsole.VelibServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VelibServices.IVelibServices", CallbackContract=typeof(VelibClientConsole.VelibServices.IVelibServicesCallback))]
    public interface IVelibServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/GetStationsInCity", ReplyAction="http://tempuri.org/IVelibServices/GetStationsInCityResponse")]
        VelibLibrary.Station[] GetStationsInCity(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/GetStationsInCity", ReplyAction="http://tempuri.org/IVelibServices/GetStationsInCityResponse")]
        System.Threading.Tasks.Task<VelibLibrary.Station[]> GetStationsInCityAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/GetAvailableVelibsInStation", ReplyAction="http://tempuri.org/IVelibServices/GetAvailableVelibsInStationResponse")]
        VelibLibrary.Station GetAvailableVelibsInStation(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/GetAvailableVelibsInStation", ReplyAction="http://tempuri.org/IVelibServices/GetAvailableVelibsInStationResponse")]
        System.Threading.Tasks.Task<VelibLibrary.Station> GetAvailableVelibsInStationAsync(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/StationSubEvent", ReplyAction="http://tempuri.org/IVelibServices/StationSubEventResponse")]
        VelibLibrary.Station StationSubEvent(int time, string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/StationSubEvent", ReplyAction="http://tempuri.org/IVelibServices/StationSubEventResponse")]
        System.Threading.Tasks.Task<VelibLibrary.Station> StationSubEventAsync(int time, string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/SubscribeToStationEvent", ReplyAction="http://tempuri.org/IVelibServices/SubscribeToStationEventResponse")]
        void SubscribeToStationEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/SubscribeToStationEvent", ReplyAction="http://tempuri.org/IVelibServices/SubscribeToStationEventResponse")]
        System.Threading.Tasks.Task SubscribeToStationEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/UnsubscribeToStationEvent", ReplyAction="http://tempuri.org/IVelibServices/UnsubscribeToStationEventResponse")]
        void UnsubscribeToStationEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibServices/UnsubscribeToStationEvent", ReplyAction="http://tempuri.org/IVelibServices/UnsubscribeToStationEventResponse")]
        System.Threading.Tasks.Task UnsubscribeToStationEventAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibServicesCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IVelibServices/StationVelibInfo")]
        void StationVelibInfo(VelibLibrary.Station station);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibServicesChannel : VelibClientConsole.VelibServices.IVelibServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibServicesClient : System.ServiceModel.DuplexClientBase<VelibClientConsole.VelibServices.IVelibServices>, VelibClientConsole.VelibServices.IVelibServices {
        
        public VelibServicesClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public VelibServicesClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public VelibServicesClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServicesClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServicesClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public VelibLibrary.Station[] GetStationsInCity(string city) {
            return base.Channel.GetStationsInCity(city);
        }
        
        public System.Threading.Tasks.Task<VelibLibrary.Station[]> GetStationsInCityAsync(string city) {
            return base.Channel.GetStationsInCityAsync(city);
        }
        
        public VelibLibrary.Station GetAvailableVelibsInStation(string city, string station) {
            return base.Channel.GetAvailableVelibsInStation(city, station);
        }
        
        public System.Threading.Tasks.Task<VelibLibrary.Station> GetAvailableVelibsInStationAsync(string city, string station) {
            return base.Channel.GetAvailableVelibsInStationAsync(city, station);
        }
        
        public VelibLibrary.Station StationSubEvent(int time, string city, string station) {
            return base.Channel.StationSubEvent(time, city, station);
        }
        
        public System.Threading.Tasks.Task<VelibLibrary.Station> StationSubEventAsync(int time, string city, string station) {
            return base.Channel.StationSubEventAsync(time, city, station);
        }
        
        public void SubscribeToStationEvent() {
            base.Channel.SubscribeToStationEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeToStationEventAsync() {
            return base.Channel.SubscribeToStationEventAsync();
        }
        
        public void UnsubscribeToStationEvent() {
            base.Channel.UnsubscribeToStationEvent();
        }
        
        public System.Threading.Tasks.Task UnsubscribeToStationEventAsync() {
            return base.Channel.UnsubscribeToStationEventAsync();
        }
    }
}
