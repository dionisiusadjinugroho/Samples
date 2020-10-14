using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Formatter;
using MQTTnet.Protocol;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace YasunliplastApp.Utils
{
    public class MqttHelper
    {
        Timer timer_wait;
        private IMqttClient _mqttClient;
        //Variable Global List History Picking & Stocking
        List<SamplingQC> GlobalSamplingQC = new List<SamplingQC>();
        public List<string> GlobalSamplingHeaderDokNo = new List<string>();
        public SamplingBarcode GlobalSamplingBarcode = new SamplingBarcode();
        public List<SamplingDokNo> GlobalSamplingDokNo2 = new List<SamplingDokNo>();
        public SamplingOperator GlobalSamplingOperator = new SamplingOperator();
        public List<ReportSampling> GlobalListReportSampling = new List<ReportSampling>();

        public MqttHelper()
        {
            //Initialize Timer Wait For Reconnect MQTT
            timer_wait = new Timer();
            timer_wait.Interval = 1000;
            timer_wait.Elapsed += TimerWaitEvent_Tick;
            timer_wait.Stop();


            Start_ConnectMQTT();
        }

        private async void Start_ConnectMQTT()
        {
            try
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
                        //Server = "broker.hivemq.com",
                        //Server = "mqtt.eclipse.org",
                        //Server = "117.54.238.74",  //YAUP CIBITUNG
                        Server = "192.168.77.3",  //YAUP CIBITUNG
                        //Server = "103.150.108.26",  //YAUP LEGOK
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
                    options.KeepAlivePeriod = TimeSpan.FromSeconds(5);

                    try
                    {

                        if (_mqttClient != null)
                        {
                            //await _mqttClient.DisconnectAsync();
                            //_mqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessage);
                            //_mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected(x));
                            //_mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected(x));

                        }


                        _mqttClient = mqttfactory.CreateMqttClient();
                        _mqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessage);
                        _mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected(x));
                        _mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected(x));

                        await _mqttClient.ConnectAsync(options);
                    }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
                    catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
                    {
                        timer_wait.Enabled = true;
                    }

                }
#pragma warning disable CS0168 // The variable 'exception' is declared but never used
                catch (Exception exception)
#pragma warning restore CS0168 // The variable 'exception' is declared but never used
                {
                    timer_wait.Enabled = true;
                }


            }
            catch (Exception)
            {
                timer_wait.Enabled = true;
                //throw;
            }
        }

        private void OnDisconnected(MqttClientDisconnectedEventArgs x)
        {
            AppSettings.IsMqttConnected = false;
            timer_wait.Enabled = true;
        }

        private void OnConnected(MqttClientConnectedEventArgs x)
        {
            AppSettings.IsMqttConnected = true;
            timer_wait.Enabled = false;
        }

#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        private async Task HandleReceivedApplicationMessage(MqttApplicationMessageReceivedEventArgs eventArgs)
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {
            var item = $"Timestamp: {DateTime.Now:O} | Topic: {eventArgs.ApplicationMessage.Topic} | Payload: {eventArgs.ApplicationMessage.ConvertPayloadToString()} | QoS: {eventArgs.ApplicationMessage.QualityOfServiceLevel}";
            string topic = eventArgs.ApplicationMessage.Topic;
            string RecvMsg = eventArgs.ApplicationMessage.ConvertPayloadToString();



            if (topic == "RESPON_BARCODE_TRIAL_INJECTION_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_TRIAL_INJECTION, RecvMsg);
            }

            if (topic == "RESPON_SCAN_STO" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_SCAN_STO, RecvMsg);
            }

            if (topic == "STO_LOC_GUDANG" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_GUDANG, RecvMsg);
            }

            if (topic == "RESPON_LOCATION_GUDANG_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_GUDANG, RecvMsg);
            }

            if (topic == "RESPON_BARCODE_RFID_PAIRING_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_RFID_PAIRING, RecvMsg);
            }

            if (topic == "RESPON_SAVE_RFID_PAIRING_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_SAVE_RFID_PAIRING, RecvMsg);
            }

            if (topic == "RESPON_RFID_DELIVERY_IN_GUDANG_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_RFID_DELIVERY_IN_GUDANG, RecvMsg);
            }

            if (topic == "RESPON_MOBIL_DELIVERY_EPSON_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_MOBIL_DELIVERY_EPSON, RecvMsg);
            }

            if (topic == "RESPON_RFID_DELIVERY_EPSON_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_RFID_DELIVERY_EPSON, RecvMsg);
            }

            if (topic == "RESPON_BARCODE_LOCATION_REWORK_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_LOCATION_REWORK, RecvMsg);
            }

            if (topic == "RESPON_LOCATION_REWORK_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_LOCATION_REWORK, RecvMsg);
            }

            if (topic == "RESPON_BARCODE_REWORK_ABCD" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPON_BARCODE_REWORK_IN, RecvMsg);
            }

            if (topic == "RESPON_BARCODE_DEMO_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.RESPOND_BARCODE_DEMO, RecvMsg);
            }

            if (topic == "SAVE_RESPOND_SPP_AKTIVITAS_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.SAVE_RESPOND_SPP_AKTIVITAS, RecvMsg);
            }

            if (topic == "SEND_LIST_SPP_AKTIVITAS_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.SEND_LIST_SPP_AKTIVITAS, RecvMsg);
            }

            if (topic == "SEND_SCHEDULING_1" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.Scheduling, RecvMsg);
            }

            if (topic == "SEND_SURKOM_LIST" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.Surkoms, RecvMsg);
            }

            if (topic == "SAVE_SCHEDULING_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.ResponseSave, RecvMsg);
            }

            if (topic == "SENDITEMALL_" + GlobalVar.MacAddress)
            {
                string[] strsplit = RecvMsg.Split(',');

                List<string> strarray = new List<string>();

                foreach (string newstr in strsplit)
                {
                    strarray.Add(newstr); //Result: strarray[0] = ItemID/ItemName/Model
                }
                MessagingCenter.Send<MqttHelper, List<string>>(this, MessagingCenterKeys.SENDITEMALL_, strarray);
            }

            if (topic == "RESPON_MONITORING_STOCK_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.MonitoringStock, RecvMsg);
            }

            if (topic == "RIWAYAT_BOX" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.InfoDetail, RecvMsg);
            }

            if (topic == "DATA_MACHINE_ABSENSI_OP" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.DATA_MACHINE_ABSENSI_OP, RecvMsg);
            }

            if (topic == "DATA_ABSENSI_OP" + GlobalVar.MacAddress)
            {
                if (RecvMsg == "WRONGDATA")
                {
                    MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.Data_Absensi_OP, RecvMsg);
                }
                else
                {
                    string[] strsplit = RecvMsg.Split(',');

                    List<string> strarray = new List<string>();

                    foreach (string newstr in strsplit)
                    {
                        strarray.Add(newstr); //Result: strarray[0] = CODE OPERATOR/MACHINE , strarray[1] = OP/Machine ID , strarray[2] = OP/Machine NAME
                    }

                    if (strarray[0] == "OP")
                    {
                        GlobalVar.OperatorNPK = strarray[1];
                        GlobalVar.OperatorName = strarray[2];
                        MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.Data_Absensi_OP, "OP");
                    }
                    if (strarray[0] == "MC")
                    {
                        GlobalVar.MachineID = strarray[1];
                        GlobalVar.MachineName = strarray[2];
                        MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.Data_Absensi_OP, "MC");
                    }
                }
            }

            if (topic == "SAVE_RESPOND_ABSENSI_OP" + GlobalVar.MacAddress)
            {
                if (RecvMsg == "SUCCESS")
                {
                    MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.Save_Respon, "SUCCESS");
                }
                if (RecvMsg == "FAILED")
                {
                    MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.Save_Respon, "FAILED");
                }
            }

            if (topic == "ReportAbsensi_ServerToClient_" + GlobalVar.MacAddress)
            {
                string[] strsplit = RecvMsg.Split(',');
                //_listreportAbsensi = new List<ReportAbsensi>();
                ReportAbsensi reportAbsensis = new ReportAbsensi();

                Device.BeginInvokeOnMainThread(async () =>
                {
                    int urutan = 0;
                    int i = 0;
                    foreach (string newstr in strsplit)
                    {
                        if (i == 0)
                        {
                            reportAbsensis = new ReportAbsensi();
                            //reportAbsensis.StrBase64Photo = newstr;
                            //reportAbsensis.Photo = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(newstr)));

                            i++;
                        }
                        else if (i == 1)
                        {
                            reportAbsensis.EmployeeID = newstr;
                            //GlobalVar._listreportAbsensi[urutan].EmployeeID = newstr;
                            i++;
                        }
                        else if (i == 2)
                        {
                            reportAbsensis.EmployeeName = newstr;
                            //GlobalVar._listreportAbsensi[urutan].EmployeeName = newstr;
                            i++;
                        }
                        else if (i == 3)
                        {
                            reportAbsensis.Machine = newstr;
                            //GlobalVar._listreportAbsensi[urutan].Machine = newstr;
                            i++;
                        }
                        else if (i == 4)
                        {
                            reportAbsensis.WorkDate = newstr;
                            GlobalVar._listreportAbsensi.Add(reportAbsensis);
                            MessagingCenter.Send<MqttHelper, List<ReportAbsensi>>(this, MessagingCenterKeys.ReportAbsensi_ServerToClient_, GlobalVar._listreportAbsensi);
                            //GlobalVar._listreportAbsensi[urutan].WorkDate = newstr;
                            i = 0;
                            //urutan++;
                        }
                    }

                });
            }

            if (topic == "ReportAbsensi_ServerToClientImage_" + GlobalVar.MacAddress)
            {

                List<ImageSource> sc = new List<ImageSource>();
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var photo = ImageSource.FromStream(() => new MemoryStream(eventArgs.ApplicationMessage.Payload));
                    sc.Add(photo);
                });
                MessagingCenter.Send<MqttHelper, List<ImageSource>>(this, MessagingCenterKeys.ReportAbsensi_ServerToClientImage_, sc);
            }

            if (topic == "ReportImageAbsensiOperator_ServerToClient_" + GlobalVar.MacAddress)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    //ReportAbsensi reportAbsensis = new ReportAbsensi();
                    //reportAbsensis.EmployeeID = "AAAAA";
                    //reportAbsensis.EmployeeName = "BBBBBBBB";
                    //reportAbsensis.Machine = "CCCCCC";
                    //reportAbsensis.WorkDate = "WORKDATE";


                    //reportAbsensis.StrBase64Photo = RecvMsg;
                    //var stream1 = new MemoryStream(Convert.FromBase64String(reportAbsensis.StrBase64Photo));
                    //reportAbsensis.Photo = ImageSource.FromStream(() => stream1);


                    //reportAbsensis.StrBase64Photo = "";
                    //reportAbsensis.Photo = ImageSource.FromStream(() => new MemoryStream(eventArgs.ApplicationMessage.Payload));


                    if (GlobalVar.urutanPhotoAbsensi <= GlobalVar._listreportAbsensi.Count)
                    {
                        GlobalVar._listreportAbsensi[GlobalVar.urutanPhotoAbsensi].Photo = ImageSource.FromStream(() => new MemoryStream(eventArgs.ApplicationMessage.Payload));

                        GlobalVar.urutanPhotoAbsensi++;
                        MessagingCenter.Send<MqttHelper, List<ReportAbsensi>>(this, MessagingCenterKeys.ReportAbsensi_ServerToClient_, GlobalVar._listreportAbsensi);
                    }




                    //GlobalVar._listreportAbsensi.Add(reportAbsensis);
                    //MessagingCenter.Send<MqttHelper, List<ReportAbsensi>>(this, MessagingCenterKeys.ReportAbsensi_ServerToClient_, _listreportAbsensi);

                });


                //var stream1 = new MemoryStream(Convert.FromBase64String(RecvMsg));

                //reportAbsensis.Photo.Source = ImageSource.FromStream(() => stream1);



                //reportAbsensis.Photo = ImageSource.FromResource("Attendance");



            }

            if (topic == "ReportAbsensiFAIL_ServerToClient_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.ReportAbsensiFAIL_ServerToClient_, RecvMsg);
            }


            if (topic == "SamplingAdd_ServerToClientA" + GlobalVar.MacAddress)
            {
                string[] strsplit = RecvMsg.Split(',');

                List<string> strarray = new List<string>();

                foreach (string newstr in strsplit)
                {
                    strarray.Add(newstr); //Result: strarray[0] = BARCODE , strarray[1] = ITEM_ID , strarray[2] = ITEM_NAME , strarray[3] = QTY
                }
                ///////FORMAT/////DATA MQTT History Picking    /////"PART_NAME,BARCODE_WO,REMAINING_STOCK,QTY_PICK_UP,DATE_TAKEN"/////
                SamplingQC samplingQc = new SamplingQC();
                samplingQc.BARCODE = strarray[0];   //As BARCODE
                samplingQc.ITEM_ID = strarray[1];    //As ITEM_ID
                samplingQc.ITEM_NAME = strarray[2];    //As ITEM_NAME
                samplingQc.NPK = strarray[3];    //As QTY
                GlobalSamplingQC.Add(samplingQc);
                MessagingCenter.Send<MqttHelper, List<SamplingQC>>(this, MessagingCenterKeys.SamplingAdd_ServerToClientA, GlobalSamplingQC);


            }

            if (topic == "SamplingHeaderDokNo_ServerToClientA" + GlobalVar.MacAddress)
            {
                string[] strsplit = RecvMsg.Split(',');
                GlobalSamplingHeaderDokNo = new List<string>();

                List<string> strarray = new List<string>();

                foreach (string newstr in strsplit)
                {
                    strarray.Add(newstr);
                    GlobalSamplingHeaderDokNo.Add(newstr);

                    SamplingDokNo samplingDokNo = new SamplingDokNo();
                    samplingDokNo._documentno = newstr;
                    GlobalSamplingDokNo2.Add(samplingDokNo);
                }

                MessagingCenter.Send<MqttHelper, List<string>>(this, MessagingCenterKeys.SamplingHeaderDokNo_ServerToClientA, GlobalSamplingHeaderDokNo);
            }


            if (topic == "SamplingBarcode_ServerToClientA" + GlobalVar.MacAddress)
            {
                string[] strsplit = RecvMsg.Split(',');
                GlobalSamplingBarcode = new SamplingBarcode();

                List<string> strarray = new List<string>();

                foreach (string newstr in strsplit)
                {
                    strarray.Add(newstr); //Result: strarray[0] = BARCODE , strarray[1] = ITEM_ID , strarray[2] = ITEM_NAME
                }
                ////FORMAT => "BARCODE,ITEMID,ITEMNAME"
                ///
                GlobalSamplingBarcode.Barcode = strarray[0];
                GlobalSamplingBarcode.ItemID = strarray[1];
                GlobalSamplingBarcode.ItemName = strarray[2];

                MessagingCenter.Send<MqttHelper, SamplingBarcode>(this, MessagingCenterKeys.SamplingBarcode_ServerToClientA, GlobalSamplingBarcode);
            }


            if (topic == "SamplingOperator_ServerToClientA" + GlobalVar.MacAddress)
            {
                string[] strsplit = RecvMsg.Split(',');
                GlobalSamplingOperator = new SamplingOperator();

                List<string> strarray = new List<string>();

                foreach (string newstr in strsplit)
                {
                    strarray.Add(newstr); //Result: strarray[0] = NPK , strarray[1] = EmployeeName
                }
                ////FORMAT => "NPK,EmployeeName"
                ///
                GlobalSamplingOperator.NPK = strarray[0];
                GlobalSamplingOperator.EmployeeName = strarray[1];

                MessagingCenter.Send<MqttHelper, SamplingOperator>(this, MessagingCenterKeys.SamplingOperator_ServerToClientA, GlobalSamplingOperator);
            }

            if (topic == "SamplingUserQC_ServerToClientA" + GlobalVar.MacAddress)
            {
                if (RecvMsg.Contains(","))
                {

                    string[] strsplit = RecvMsg.Split(',');
                    GlobalSamplingOperator = new SamplingOperator();
                    List<string> strarray = new List<string>();

                    foreach (string newstr in strsplit)
                    {
                        strarray.Add(newstr); //Result: strarray[0] = NPK , strarray[1] = EmployeeName
                    }
                    ////FORMAT => "NPK,EmployeeName"
                    ///
                    GlobalSamplingOperator.NPK = strarray[0];
                    GlobalSamplingOperator.EmployeeName = strarray[1];
                    MessagingCenter.Send<MqttHelper, SamplingOperator>(this, MessagingCenterKeys.SamplingUserQC_ServerToClientA, GlobalSamplingOperator);

                }
                else
                {
                    GlobalSamplingOperator.NPK = RecvMsg;
                    MessagingCenter.Send<MqttHelper, SamplingOperator>(this, MessagingCenterKeys.SamplingUserQC_ServerToClientA, GlobalSamplingOperator);
                }

            }

            if (topic == "SamplingStatusSaveData_ServerToClientA" + GlobalVar.MacAddress)
            {
                if (RecvMsg.Contains("SUCCESSSAVE"))
                {
                    MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.SamplingStatusSaveData_ServerToClientA, "SUCCESSSAVE");

                }
                else
                {
                    MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.SamplingStatusSaveData_ServerToClientA, "FAILSAVE");

                }
            }

            if (topic == "SamplingReportSampling_ServerToClientA" + GlobalVar.MacAddress)
            {
                string[] strsplit = RecvMsg.Split(',');
                GlobalListReportSampling = new List<ReportSampling>();
                ReportSampling reportSamplings = new ReportSampling();

                int i = 0;
                foreach (string newstr in strsplit)
                {
                    if (i == 0)
                    {
                        reportSamplings = new ReportSampling();
                        reportSamplings.BarcodeID = newstr;
                        i++;
                    }
                    else if (i == 1)
                    {
                        reportSamplings.EmployeeName = newstr;
                        i++;
                    }
                    else if (i == 2)
                    {
                        reportSamplings.SamplingTime = newstr;
                        i++;
                    }
                    else if (i == 3)
                    {
                        reportSamplings.ItemID = newstr;
                        i++;
                    }
                    else if (i == 4)
                    {
                        reportSamplings.ItemName = newstr;
                        i++;
                    }
                    else if (i == 5)
                    {
                        reportSamplings.Output = newstr;
                        GlobalListReportSampling.Add(reportSamplings);
                        i = 0;
                    }

                }
                MessagingCenter.Send<MqttHelper, List<ReportSampling>>(this, MessagingCenterKeys.SamplingReportSampling_ServerToClientA, GlobalListReportSampling);
            }

            if (topic == "LOGIN_AUTH_" + GlobalVar.MacAddress)
            {
                MessagingCenter.Send<MqttHelper, string>(this, MessagingCenterKeys.Login_Authorization, RecvMsg);


            }

            if (topic == "LOGIN_INFO_" + GlobalVar.MacAddress)
            {
                string[] strsplit = RecvMsg.Split(',');

                List<string> strarray = new List<string>();

                foreach (string newstr in strsplit)
                {
                    strarray.Add(newstr); //Result: strarray[0] = BARCODE , strarray[1] = ITEM_ID , strarray[2] = ITEM_NAME , strarray[3] = QTY
                }

                GlobalVar.EmployeeID = strarray[0];
                GlobalVar.EmployeeName = strarray[1];
            }

            if (topic == "LOGIN_DIV_" + GlobalVar.MacAddress)
            {
                GlobalVar.Division = RecvMsg;
            }
        }

        private void TimerWaitEvent_Tick(object sender, ElapsedEventArgs e)
        {
            timer_wait.Enabled = false;
            //Check MQTT Status
            if (_mqttClient == null)
            {
                //MQTT Disconnected
                Start_ConnectMQTT();
            }
            else
            {
                if (_mqttClient.IsConnected)
                {
                    //MQTT Connected Do Nothing
                    //WriteToFile("MQTT Connected to Server " + DateTime.Now.ToString());
                }
                else
                {
                    //MQTT Disconnected
                    Start_ConnectMQTT();
                }
            }
        }

        public async void PublishMQTT(string strPublishMsg, string strtopic)
        {
            try
            {
                //Step 1 Set QOS 1 Only
                var qos = MqttQualityOfServiceLevel.AtMostOnce;

                //Step 2 Set Message (Convert From String into Byte)
                var payload = new byte[0];
                payload = Encoding.UTF8.GetBytes(strPublishMsg);

                //Step 3 Set Message Publish No Retain
                var message = new MqttApplicationMessageBuilder()
                    .WithContentType(null)
                    .WithResponseTopic(null)
                    .WithTopic(strtopic)
                    .WithPayload(payload)
                    .WithQualityOfServiceLevel(qos)
                    .WithRetainFlag(false)
                    .Build();

                //Step 4 Start Publish the Messages
                if (_mqttClient != null && _mqttClient.IsConnected)
                {
                    await _mqttClient.PublishAsync(message);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }

        public async void SubscribeMQTT(string Topic)
        {
            try
            {
                //Step 1 Set QOS (0,1,2)
                var qos = MqttQualityOfServiceLevel.AtMostOnce;

                TopicFilter topicFilter = new TopicFilter();

                topicFilter = new TopicFilter { Topic = Topic, QualityOfServiceLevel = qos };


                if (_mqttClient != null)
                {
                    await _mqttClient.SubscribeAsync(topicFilter);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }

    }
}
