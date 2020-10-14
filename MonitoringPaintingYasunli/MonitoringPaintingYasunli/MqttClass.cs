using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Formatter;
using MQTTnet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace MonitoringPaintingYasunli
{
    public static class MqttClass
    {
        static Timer timer_mqtt = new Timer(); // name space(using System.Timers;)
        static Timer timer_status = new Timer(); // name space(using System.Timers;)
        static string status;
        static IMqttClient _mqttClient;

        static MqttClass()
        {
            timer_mqtt.Elapsed += new ElapsedEventHandler(OnElapsedTime_MQTT);
            timer_mqtt.Interval = 3000; //number in milliseconds
            timer_mqtt.Enabled = true;

            timer_status.Elapsed += new ElapsedEventHandler(OnElapsedTime_MQTTSUB);
            timer_status.Interval = 1000; //number in milliseconds
            timer_status.Enabled = true;
        }

        private static void OnElapsedTime_MQTTSUB(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (_mqttClient != null && _mqttClient.IsConnected)
                {
                    SubscribeMQTT("MONITORINGPAINTING");

                }
            }
            catch (Exception ex)
            {
                CheckTimer();
            }
        }

        private static void OnElapsedTime_MQTT(object sender, ElapsedEventArgs e)
        {
            //WriteToFile(string.Format("STATUS MQTT : {0}    {1}", status, DateTime.Now.ToString("dd MMM yyyy HH:mm")));



            //Check MQTT Status
            if (_mqttClient == null)
            {
                CheckTimer();
                //MQTT Disconnected
                status = "DISCONNECTED";
                MQTT_Connect();
            }
            else
            {
                if (_mqttClient.IsConnected)
                {
                    //MQTT Connected Do Nothing
                    //WriteToFile("MQTT Connected to Server " + DateTime.Now.ToString());
                    status = "CONNECTED";
                }
                else
                {
                    CheckTimer();
                    //MQTT Disconnected
                    status = "DISCONNECTED";
                    MQTT_Connect();
                }
            }
        }

        internal static async void MQTT_Connect()
        {
            try
            {
                //Step 1 Set MQTT TLS
                var mqttfactory = new MqttFactory();

                var tlsOptions = new MqttClientTlsOptions
                {
                    UseTls = false,
                    IgnoreCertificateChainErrors = true,
                    IgnoreCertificateRevocationErrors = true,
                    AllowUntrustedCertificates = true
                };

                string client = Guid.NewGuid().ToString();
                //Step 2 Set MQTT Client Options
                var options = new MqttClientOptions
                {
                    ClientId = client,
                    ProtocolVersion = MqttProtocolVersion.V500
                };

                //Step 3 MQTT Client Using TCP
                //Connect to MQTT PUBLIC SERVER broker.hivemq.com
                options.ChannelOptions = new MqttClientTcpOptions
                {
                    Server = "mqtt.eclipse.org",
                    //Server = "broker.hivemq.com",
                    //Server = "117.54.238.74",   //YAUP CIBITUNG
                    //Server = "192.168.77.3",   //YAUP CIBITUNG
                    //Server = "103.150.108.26",   //YAUP LEGOK
                    Port = 1883,
                    TlsOptions = tlsOptions
                };

                //Step 5 Check If MQTT Client Options Null Call Exception
                if (options.ChannelOptions == null)
                {
                    throw new InvalidOperationException();
                }

                //Step 7 MQTT Keep Alive Event
                options.CleanSession = true;
                options.KeepAlivePeriod = TimeSpan.FromSeconds(60);

                try
                {

                    if (_mqttClient != null)
                    {
                        await _mqttClient.DisconnectAsync();
                        _mqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessage);
                        _mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected(x));
                        _mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected(x));
                    }


                    _mqttClient = mqttfactory.CreateMqttClient();
                    _mqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessage);
                    _mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected(x));
                    _mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected(x));


                    await _mqttClient.ConnectAsync(options);
                }
                catch (Exception ex)
                {
                    timer_mqtt.Enabled = true;
                    status = "DISCONNECTED";
                }

            }
            catch (Exception ex)
            {
                timer_mqtt.Enabled = true;
                status = "DISCONNECTED";
            }
        }

        private static void OnDisconnected(MqttClientDisconnectedEventArgs x)
        {

            CheckTimer();
            status = "DISCONNECTED";
            //WriteToFile(string.Format("STATUS MQTT : {0}    {1}", status, DateTime.Now.ToString("dd MMM yyyy HH:mm")));

        }

        private static void OnConnected(MqttClientConnectedEventArgs x)
        {
            //timer_mqtt.Enabled = false;
            status = "CONNECTED";
            //WriteToFile(string.Format("STATUS MQTT : {0}    {1}", status, DateTime.Now.ToString("dd MMM yyyy HH:mm")));
        }

        public static async Task HandleReceivedApplicationMessage(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            var item = $"Timestamp: {DateTime.Now:O} | Topic: {eventArgs.ApplicationMessage.Topic} | Payload: {eventArgs.ApplicationMessage.ConvertPayloadToString()} | QoS: {eventArgs.ApplicationMessage.QualityOfServiceLevel}";
            string topic = eventArgs.ApplicationMessage.Topic;
            string RecvMsg = eventArgs.ApplicationMessage.ConvertPayloadToString();

            if(topic == "MONITORINGPAINTING")
            {
                try
                {
                    string[] strsplit = RecvMsg.Split(',');
                    string NEWDATATYPE = strsplit[0];
                    string NEWDATASCANCOUNT = strsplit[1];
                    string OLDDATATYPE = strsplit[2];
                    string OLDDATASCANCOUNT = strsplit[3];
                    string ITEMNAME = strsplit[4];
                    string COLOUR = strsplit[5];

                    await Task.Run(() =>
                    {
                        if (string.IsNullOrEmpty(OLDDATATYPE) || string.IsNullOrEmpty(OLDDATASCANCOUNT))
                        {
                            var checkexist = MonitoringPaintingSource._listMonitoringPaintingDetail.Where(x => x.ItemName == ITEMNAME && x.Colour == COLOUR).FirstOrDefault();
                            if(checkexist != null)
                            {
                                for (int i = 0; i < MonitoringPaintingSource._listMonitoringPaintingDetail.Count; i++)
                                {
                                    if (MonitoringPaintingSource._listMonitoringPaintingDetail[i].ItemName == ITEMNAME && MonitoringPaintingSource._listMonitoringPaintingDetail[i].Colour == COLOUR)
                                    {
                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].RawPart++;
                                        switch (NEWDATATYPE)
                                        {
                                            case "REPAINT":
                                                switch (NEWDATASCANCOUNT)
                                                {
                                                    case "0":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].R0++;
                                                        break;
                                                    case "1":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].R1++;
                                                        break;
                                                    case "2":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].R2++;
                                                        break;
                                                    case "3":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].R3++;
                                                        break;
                                                    case "4":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].R4++;
                                                        break;
                                                    case "5":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].R5++;
                                                        break;
                                                }
                                                break;
                                            case "OKPAINTING":
                                                switch (NEWDATASCANCOUNT)
                                                {
                                                    case "0":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK0++;
                                                        break;
                                                    case "1":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK1++;
                                                        break;
                                                    case "2":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK2++;
                                                        break;
                                                    case "3":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK3++;
                                                        break;
                                                    case "4":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK4++;
                                                        break;
                                                    case "5":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK5++;
                                                        break;
                                                }
                                                break;
                                            case "NG":
                                                switch (NEWDATASCANCOUNT)
                                                {
                                                    case "0":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG0++;
                                                        break;
                                                    case "1":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG1++;
                                                        break;
                                                    case "2":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG2++;
                                                        break;
                                                    case "3":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG3++;
                                                        break;
                                                    case "4":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG4++;
                                                        break;
                                                    case "5":
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                        MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG5++;
                                                        break;
                                                }
                                                break;
                                            case "RAWPART":
                                                MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                MonitoringPaintingSource._listMonitoringPaintingDetail[i].R0++;
                                                break;
                                        }

                                        break;
                                    }
                                }

                            }
                            else
                            {
                                MonitoringPaintingDetail mpdet = new MonitoringPaintingDetail();
                                mpdet.ItemName = ITEMNAME;
                                mpdet.Colour = COLOUR;
                                mpdet.RawPart++;
                                switch (NEWDATATYPE)
                                {
                                    case "REPAINT":
                                        switch (NEWDATASCANCOUNT)
                                        {
                                            case "0":
                                                mpdet.TotalRepaint++;
                                                mpdet.R0++;
                                                break;
                                            case "1":
                                                mpdet.TotalRepaint++;
                                                mpdet.R1++;
                                                break;
                                            case "2":
                                                mpdet.TotalRepaint++;
                                                mpdet.R2++;
                                                break;
                                            case "3":
                                                mpdet.TotalRepaint++;
                                                mpdet.R3++;
                                                break;
                                            case "4":
                                                mpdet.TotalRepaint++;
                                                mpdet.R4++;
                                                break;
                                            case "5":
                                                mpdet.TotalRepaint++;
                                                mpdet.R5++;
                                                break;
                                        }
                                        break;
                                    case "OKPAINTING":
                                        switch (NEWDATASCANCOUNT)
                                        {
                                            case "0":
                                                mpdet.TotalOK++;
                                                mpdet.OK0++;
                                                break;
                                            case "1":
                                                mpdet.TotalOK++;
                                                mpdet.OK1++;
                                                break;
                                            case "2":
                                                mpdet.TotalOK++;
                                                mpdet.OK2++;
                                                break;
                                            case "3":
                                                mpdet.TotalOK++;
                                                mpdet.OK3++;
                                                break;
                                            case "4":
                                                mpdet.TotalOK++;
                                                mpdet.OK4++;
                                                break;
                                            case "5":
                                                mpdet.TotalOK++;
                                                mpdet.OK5++;
                                                break;
                                        }
                                        break;
                                    case "NG":
                                        switch (NEWDATASCANCOUNT)
                                        {
                                            case "0":
                                                mpdet.TotalNG++;
                                                mpdet.NG0++;
                                                break;
                                            case "1":
                                                mpdet.TotalNG++;
                                                mpdet.NG1++;
                                                break;
                                            case "2":
                                                mpdet.TotalNG++;
                                                mpdet.NG2++;
                                                break;
                                            case "3":
                                                mpdet.TotalNG++;
                                                mpdet.NG3++;
                                                break;
                                            case "4":
                                                mpdet.TotalNG++;
                                                mpdet.NG4++;
                                                break;
                                            case "5":
                                                mpdet.TotalNG++;
                                                mpdet.NG5++;
                                                break;
                                        }
                                        break;
                                    case "RAWPART":
                                        mpdet.TotalRepaint++;
                                        mpdet.R0++;
                                        break;
                                }
                                MonitoringPaintingSource._listMonitoringPaintingDetail.Add(mpdet);

                            }

                        }
                        else
                        {
                            if (MonitoringPaintingSource._listMonitoringPaintingDetail.Count > 0)
                            {
                                for (int i = 0; i < MonitoringPaintingSource._listMonitoringPaintingDetail.Count; i++)
                                {
                                    if (MonitoringPaintingSource._listMonitoringPaintingDetail[i].ItemName == ITEMNAME)
                                    {
                                        if (MonitoringPaintingSource._listMonitoringPaintingDetail[i].ItemName == ITEMNAME && MonitoringPaintingSource._listMonitoringPaintingDetail[i].Colour == COLOUR)
                                        {
                                            #region NEWDATATYPE
                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].RawPart++;
                                            switch (NEWDATATYPE)
                                            {
                                                case "REPAINT":
                                                    switch (NEWDATASCANCOUNT)
                                                    {
                                                        case "0":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R0++;
                                                            break;
                                                        case "1":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R1++;
                                                            break;
                                                        case "2":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R2++;
                                                            break;
                                                        case "3":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R3++;
                                                            break;
                                                        case "4":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R4++;
                                                            break;
                                                        case "5":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R5++;
                                                            break;
                                                    }
                                                    break;
                                                case "OKPAINTING":
                                                    switch (NEWDATASCANCOUNT)
                                                    {
                                                        case "0":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK0++;
                                                            break;
                                                        case "1":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK1++;
                                                            break;
                                                        case "2":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK2++;
                                                            break;
                                                        case "3":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK3++;
                                                            break;
                                                        case "4":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK4++;
                                                            break;
                                                        case "5":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK5++;
                                                            break;
                                                    }
                                                    break;
                                                case "NG":
                                                    switch (NEWDATASCANCOUNT)
                                                    {
                                                        case "0":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG0++;
                                                            break;
                                                        case "1":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG1++;
                                                            break;
                                                        case "2":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG2++;
                                                            break;
                                                        case "3":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG3++;
                                                            break;
                                                        case "4":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG4++;
                                                            break;
                                                        case "5":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG++;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG5++;
                                                            break;
                                                    }
                                                    break;
                                                case "RAWPART":
                                                    MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint++;
                                                    MonitoringPaintingSource._listMonitoringPaintingDetail[i].R0++;
                                                    break;
                                            }
                                            #endregion


                                            #region OLDDATATYPE
                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].RawPart--;
                                            switch (OLDDATATYPE)
                                            {
                                                case "REPAINT":
                                                    switch (OLDDATASCANCOUNT)
                                                    {
                                                        case "0":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R0--;
                                                            break;
                                                        case "1":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R1--;
                                                            break;
                                                        case "2":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R2--;
                                                            break;
                                                        case "3":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R3--;
                                                            break;
                                                        case "4":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R4--;
                                                            break;
                                                        case "5":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].R5--;
                                                            break;
                                                    }
                                                    break;
                                                case "OKPAINTING":
                                                    switch (OLDDATASCANCOUNT)
                                                    {
                                                        case "0":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK0--;
                                                            break;
                                                        case "1":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK1--;
                                                            break;
                                                        case "2":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK2--;
                                                            break;
                                                        case "3":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK3--;
                                                            break;
                                                        case "4":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK4--;
                                                            break;
                                                        case "5":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalOK--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].OK5--;
                                                            break;
                                                    }
                                                    break;
                                                case "NG":
                                                    switch (OLDDATASCANCOUNT)
                                                    {
                                                        case "0":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG0--;
                                                            break;
                                                        case "1":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG1--;
                                                            break;
                                                        case "2":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG2--;
                                                            break;
                                                        case "3":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG3--;
                                                            break;
                                                        case "4":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG4--;
                                                            break;
                                                        case "5":
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalNG--;
                                                            MonitoringPaintingSource._listMonitoringPaintingDetail[i].NG5--;
                                                            break;
                                                    }
                                                    break;
                                                case "RAWPART":
                                                    MonitoringPaintingSource._listMonitoringPaintingDetail[i].TotalRepaint--;
                                                    MonitoringPaintingSource._listMonitoringPaintingDetail[i].R0--;
                                                    break;
                                            }
                                            #endregion


                                            break;
                                        }

                                    }
                                }
                            }
                        }
                        MainWindow._Form1.dashboardcontrol1.Dispatcher.Invoke(() =>
                        {
                            MainWindow._Form1.dashboardcontrol1.ReloadData();
                        });
                    });
                }
                catch (Exception ex)
                {

                }
            }





        }
        async static void SubscribeMQTT(string Topic)
        {
            try
            {
                //Step 1 Set QOS (0,1,2)
                var qos = MqttQualityOfServiceLevel.AtMostOnce;

                TopicFilter topicFilter = new TopicFilter();

                topicFilter = new TopicFilter { Topic = Topic, QualityOfServiceLevel = qos };


                if (_mqttClient != null)
                {
                    if (_mqttClient.IsConnected)
                    {
                        await _mqttClient.SubscribeAsync(topicFilter);
                    }
                }
            }
            catch (Exception ex)
            {
                //WriteToFile(string.Format("ERROR SUBSCRIBE : {0}  {1}", ex.Message, DateTime.Now.ToString("dd MMM yyyy HH:mm")));
            }
        }

        async static void PublishMQTT_Byte(string Topic, byte[] msgByte)
        {
            try
            {
                //Step 1 Set QOS (0,1,2)
                var qos = MqttQualityOfServiceLevel.AtMostOnce;

                //Step 2 Set Message (Convert From String into Byte)
                var payload = new byte[0];
                payload = msgByte;

                var message = new MqttApplicationMessageBuilder()
                    .WithContentType(null)
                    .WithResponseTopic(null)
                    .WithTopic(Topic)
                    .WithPayload(payload)
                    .WithQualityOfServiceLevel(qos)
                    .WithRetainFlag(false)
                    .Build();

                //Step 4 Start Publish the Messages
                if (_mqttClient != null)
                {
                    if (_mqttClient.IsConnected)
                    {
                        await _mqttClient.PublishAsync(message);
                    }
                }
            }
            catch (Exception ex)
            {
                CheckTimer();
                //WriteToFile(string.Format("ERROR PUBLISH : {0}  {1}", ex.Message, DateTime.Now.ToString("dd MMM yyyy HH:mm")));

            }

        }


        async static void PublishMQTT(string Topic, string msg)
        {
            try
            {
                //Step 1 Set QOS (0,1,2)
                var qos = MqttQualityOfServiceLevel.AtMostOnce;

                //Step 2 Set Message (Convert From String into Byte)
                var payload = new byte[0];
                payload = Encoding.UTF8.GetBytes(msg);

                var message = new MqttApplicationMessageBuilder()
                    .WithContentType(null)
                    .WithResponseTopic(null)
                    .WithTopic(Topic)
                    .WithPayload(payload)
                    .WithQualityOfServiceLevel(qos)
                    .WithRetainFlag(false)
                    .Build();

                //Step 4 Start Publish the Messages
                if (_mqttClient != null)
                {
                    if (_mqttClient.IsConnected)
                    {
                        await _mqttClient.PublishAsync(message);
                    }
                }
            }
            catch (Exception ex)
            {
                CheckTimer();
                //WriteToFile(string.Format("ERROR PUBLISH : {0}  {1}", ex.Message, DateTime.Now.ToString("dd MMM yyyy HH:mm")));

            }

        }
        static void CheckTimer()
        {
            if (timer_mqtt.Enabled != true)
            {
                timer_mqtt.Enabled = true;
            }

            if (timer_status.Enabled != true)
            {
                timer_status.Enabled = true;
            }
        }

    }
}
