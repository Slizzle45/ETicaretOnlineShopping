﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.UrunleriGetirService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new Service1()

            //};
            //ServiceBase.Run(ServicesToRun);

            Service1 service1 = new Service1();

            service1.Debug();



        }


        //1-Admin olarak cmd çalıştır ve cd deyip InstallUtil.exe path verilir
        //2-Proje path için Exe olan klasör bulur=> Proje=> Bin=> Debug=> ProjeName.Exe
        //3-eğer proje ayarları ta ise cmd ekranına
        //  InstallUtil.exe ProjePat\...\..\..\..\Bin\Debug\Service.exe
        //  yazılır ve enter denilerek Util ile Service exe si oluşturulur
        //-----------------------------------------------------------------------------------
        //Proje ayarları
        //1-Service üzerine sağ click=> Add Installer denilir
        //2-çıkan ekranda 1. ayar ola ServiceProcess User yerine localSystem yapılır
        //3-ServiceInstaller ayarları ise
        //* ServiceName
        //*DisplayName
        //* StartType
        //*Description

        //bu ayarlar yapılır
        //*************************
        //Proje debug etmek için 
        //1-Debug sekmesinde  Attach To Process
        //2-çıkan pencereden Proje adı ile service seçilir ve Attach denilerek proje debug mod ile çalıştırılır
        //NOT: Yukardaki işlemlerdde cmd ve Visual Studio Administator olarak çalıştırılması gereklidir
        //**--------------------------------
        //Projeyi silme için
        //InstallUtil.exe -u ProjePat\...\..\..\..\Bin\Debug\Service.exe

    }
}

