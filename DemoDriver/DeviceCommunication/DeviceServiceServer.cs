﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8935
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace DemoDriverDevice
{

    public static class DemoDeviceConstants
    {
        public const string HardwareEventOutOfCpuOrMemory = "OutOfCPU";
        public const string HardwareEventReboot = "Reboot";

        public const string DeviceEventActivateInput1 = "Input_Activate_1";
        public const string DeviceEventActivateInput2 = "Input_Activate_2";
        public const string DeviceEventDeactivateInput1 = "Input_Deactivate_1";
        public const string DeviceEventDeactivateInput2 = "Input_Deactivate_2";

        public const string DeviceEventMotionDetectionStart = "MD_START";
        public const string DeviceEventMotionDetectionStop = "MD_STOP";
        public const string DeviceEventLPR = "LPR:";

        public const string DeviceSettingFPS = "FPS";

        public const int DeviceVideoChannel1 = 0;
        public const int DeviceVideoChannel2 = 1;
        public const int DeviceAudioChannel = 2;
        public const int DeviceMetadataChannel1 = 8;
        public const int DeviceMetadataChannel2 = 9;
        public const int DeviceSpeakerChannel = 30;
        public const int DeviceInvalidChannel = 9999;
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IDeviceService")]
    public interface IDeviceService
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/Login", ReplyAction = "http://tempuri.org/IDeviceService/LoginResponse")]
        bool Login(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/GetMacAddress", ReplyAction = "http://tempuri.org/IDeviceService/GetMacAddressResponse")]
        string GetMacAddress();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/StartLiveStream", ReplyAction = "http://tempuri.org/IDeviceService/StartLiveStreamResponse")]
        System.Guid StartLiveStream(int channel, System.Collections.Generic.Dictionary<string, string> parameters);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/GetLiveFrame", ReplyAction = "http://tempuri.org/IDeviceService/GetLiveFrameResponse")]
        byte[] GetLiveFrame(int channel, bool coloredMetadata);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/StopLiveStream", ReplyAction = "http://tempuri.org/IDeviceService/StopLiveStreamResponse")]
        void StopLiveStream(int channel);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/PtzCommandAsText", ReplyAction = "http://tempuri.org/IDeviceService/DeviceActionResponse")]
        void SendToDemoDeviceLog(string logAction);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/SendSpeakerData", ReplyAction = "http://tempuri.org/IDeviceService/SendSpeakerDataResponse")]
        void SendSpeakerData(byte[] data);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/GetPlaybackFrame", ReplyAction = "http://tempuri.org/IDeviceService/GetPlaybackFrameResponse")]
        byte[] GetPlaybackFrame(int channel, System.DateTime dateTime);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/GetEvents", ReplyAction = "http://tempuri.org/IDeviceService/GetEventsResponse")]
        string[] GetEvents(int channel);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/SendCommand", ReplyAction = "http://tempuri.org/IDeviceService/SendCommand")]
        string SendCommand(string command);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/ChangeSetting", ReplyAction = "http://tempuri.org/IDeviceService/ChangeSetting")]
        void ChangeSetting(int channel, string key, string data);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/StartFirmwareUpgrade", ReplyAction = "http://tempuri.org/IDeviceService/StartFirmwareUpgrade")]
        Guid StartFirmwareUpgrade(string firmwareContent);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IDeviceService/GetFirmwareUpgradeProgress", ReplyAction = "http://tempuri.org/IDeviceService/GetFirmwareUpgradeProgress")]
        int GetFirmwareUpgradeProgress(Guid upgradeSessionId);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IDeviceServiceChannel : IDeviceService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class DeviceServiceClient : System.ServiceModel.ClientBase<IDeviceService>, IDeviceService
    {

        public DeviceServiceClient()
        {
        }

        public DeviceServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public DeviceServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public DeviceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public DeviceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public bool Login(string username, string password)
        {
            return base.Channel.Login(username, password);
        }

        public string GetMacAddress()
        {
            return base.Channel.GetMacAddress();
        }

        public System.Guid StartLiveStream(int channel, System.Collections.Generic.Dictionary<string, string> parameters)
        {
            return base.Channel.StartLiveStream(channel, parameters);
        }

        public byte[] GetLiveFrame(int channel, bool color)
        {
            return base.Channel.GetLiveFrame(channel, color);
        }

        public void StopLiveStream(int channel)
        {
            base.Channel.StopLiveStream(channel);
        }

        public void SendToDemoDeviceLog(string logAction)
        {
            base.Channel.SendToDemoDeviceLog(logAction);
        }

        public void SendSpeakerData(byte[] data)
        {
            base.Channel.SendSpeakerData(data);
        }

        public byte[] GetPlaybackFrame(int channel, System.DateTime dateTime)
        {
            return base.Channel.GetPlaybackFrame(channel, dateTime);
        }

        public string[] GetEvents(int channel)
        {
            return base.Channel.GetEvents(channel);
        }

        public string SendCommand(string command)
        {
            return base.Channel.SendCommand(command);
        }

        public void ChangeSetting(int channel, string key, string data)
        {
            base.Channel.ChangeSetting(channel, key, data);
        }

        public Guid StartFirmwareUpgrade(string firmwareContent)
        {
            return base.Channel.StartFirmwareUpgrade(firmwareContent);
        }

        public int GetFirmwareUpgradeProgress(Guid upgradeSessionId)
        {
            return base.Channel.GetFirmwareUpgradeProgress(upgradeSessionId);
        }
    }
}