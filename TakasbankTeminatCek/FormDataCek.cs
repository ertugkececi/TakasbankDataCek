using Business.Concrete;
using DataAccess.Concrete.FileDals;
//using DataAccess.Concrete.InMemoryDals;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakasbankTeminatCek
{
    public partial class FormDataCek : Form
    {
        //List<Symbol> newSymbolsList =  new();
        //static List<Symbol> oldSymbolList = new();
        //bool isDataChange;

        public FormDataCek()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
            //AddLogToListBoxLog("Hazır");
            //DoubleBuffered = true;
            //timerPeriod.Interval = 50000;
        }


        #region Button Medhods

        private void buttonRun_Click(object sender, EventArgs e)
        {
            //if (buttonRun.BackColor == Color.Crimson)
            //{
            //    buttonRun.BackColor = Color.MediumSeaGreen;
            //    buttonRun.Text = ">> ÇALIŞIYOR <<";
            //    SymbolReadAndWrite();
            //    timerPeriod.Start();
            //}
            //else
            //{
            //    timerPeriod.Stop();
            //    AddLogToListBoxLog("İşlem durduruldu.");
            //    buttonRun.BackColor = Color.Crimson;
            //    buttonRun.Text = ">> HAZIR <<";
            //}
        }

        private void timerPeriod_Tick(object sender, EventArgs e)
        {
            //if ((dateTimePickerFirst.Value.Hour == DateTime.Now.Hour && dateTimePickerFirst.Value.Minute == DateTime.Now.Minute) ||
            //    (dateTimePickerSecond.Value.Hour == DateTime.Now.Hour && dateTimePickerSecond.Value.Minute == DateTime.Now.Minute))
            //{
            //    SymbolReadAndWrite();

            //}
        }

        private void buttonManuel_Click(object sender, EventArgs e)
        {
            //SymbolReadAndWrite();
        }

        #endregion

        #region Personal Methods

        //İndir ve Değişikliği kontrol et
        private void SymbolReadAndWrite()
        {
            //AddLogToListBoxLog("Dosya indiriliyor.");
            //Task.Factory.StartNew(GetSymbols).ContinueWith(task =>
            //{
            //    AddLogToListBoxLog("Dosya indirildi. Veriler okundu.");
            //    if (oldSymbolList.Count == 0 || oldSymbolList == null)
            //    {
            //        for (int i = 0; i < newSymbolsList.Count; i++)
            //        {
            //            oldSymbolList.Add(newSymbolsList[i]);
            //        }
            //        isDataChange = true;
            //    }

            //    //eski data ile yeni data kıyaslaması
            //    for (int i = 0; i < newSymbolsList.Count; i++)
            //    {
            //        if (oldSymbolList != null && oldSymbolList[i].StringQuery != newSymbolsList[i].StringQuery)
            //        {
            //            isDataChange = true;
            //        }
            //    }

            //    //Data değiştiyse
            //    if (isDataChange == true)
            //    {
            //        dataGridViewSymbols.Invoke((MethodInvoker)delegate { dataGridViewSymbols.DataSource = newSymbolsList.Select(s => new { s.ContractName, s.Guarantee, s.Currency }).ToList(); });
            //        dataGridViewSymbols.Columns[0].HeaderText = "KONTRATLAR";
            //        dataGridViewSymbols.Columns[1].HeaderText = "TEMİNATLAR";
            //        dataGridViewSymbols.Columns[2].HeaderText = "PARA BİRİMİ";

            //        PathManager pathManager = new PathManager(new FilePathDal());
            //        List<string> pathList = pathManager.GetAll().Select(p => p.StringQuery).ToList();
                    
            //        SymbolManager symbolManager = new SymbolManager(new FileSymbolDal(), new PathManager(new FilePathDal()));
            //        symbolManager.AddList(newSymbolsList, pathList);
            //        AddLogToListBoxLog("Verilerde değişiklik algılandı. Teminatlar.txt güncellendi.");
            //        //SendMail(newSymbolsList);
            //        //AddLogToListBoxLog("Mail gönderildi.");

            //        isDataChange = false;
            //        oldSymbolList.Clear();
            //        oldSymbolList.AddRange(newSymbolsList);
            //    }

            //    //Data değişmediyse
            //    else
            //    {
            //        AddLogToListBoxLog("Veri değişikliği yok.");
            //    }
            //});
        }

        //Excel'den data çeken servis
        private void GetSymbols()
        {
            //ExcelFileManager excelFileManager = new ExcelFileManager(new ExcelDal());
            //newSymbolsList = excelFileManager.GetData();
        }

        //Mail gönder
        //private void SendMail(List<Symbol> symbols)
        //{
        //    StringBuilder icerik = new StringBuilder();
        //    icerik.AppendLine("Merhabalar\nTakasbank teminat verileri güncellenmiştir.\nİyi çalışmalar.\n");
        //    foreach (var symbol in symbols)
        //    {
        //        icerik.AppendLine(symbol.StringQuery);
        //    }
        //    SmtpClient client = new SmtpClient();
        //    client.Port = 587;
        //    client.EnableSsl = true;
        //    client.Host = "smtp-mail.outlook.com";
        //    client.Credentials = new NetworkCredential("idealdestek@idealdata.com.tr", "Mor43719");
        //    MailMessage msj = new MailMessage();
        //    msj.From = new MailAddress("idealdestek@idealdata.com.tr", "İdeal Data", Encoding.UTF8);
        //    msj.Subject = "Takasbank Teminat Verileri Güncellemesi";
        //    msj.To.Add("ertugk@idealdata.com.tr");
        //    msj.Body = icerik.ToString();
        //    client.Send(msj);
        //    AddLogToListBoxLog("Mail Gönderildi.");
        //}

        //Log servisine erişim (Log Dosyasına yazma)
        private void AddLogToLogFile(string message)
        {
            //LoggerManager loggerManager = new LoggerManager(new LoggerDal());
            //loggerManager.Add(new Logger { DateTime = DateTime.Now, Message = message, StringQuery = $"{DateTime.Now} => {message}" });
        }

        //Log'u aynı zamanda listBoxLog'a ekleme
        private void AddLogToListBoxLog(string message)
        {
            //AddLogToLogFile(message);
            //listBoxLog.Items.Add($"{DateTime.Now} ==> {message}");
            //listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            //listBoxLog.Focus();
        }

        #endregion
    }
}
