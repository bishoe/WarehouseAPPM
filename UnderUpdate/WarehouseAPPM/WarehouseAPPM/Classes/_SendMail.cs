using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAPPM.Classes
{
static    class _SendMail
    {
     static   public void SENDInfoPC(string EmailName,string ProductID)
        {



            var fromAddress = new MailAddress("warehousegetinfopc@gmail.com", "NEW PC");
            var toAddress = new MailAddress("warehousegetinfopc@gmail.com", "To Name");
            const string fromPassword = "WarehouseGETINFOPC@#2010";
            const string subject = "Subject";
            //const  = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,

                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = "Computer Name :=> " + _FetchHardwareInformation.GetComputerName() +
            "Processor Information  :=> " + _FetchHardwareInformation.GetProcessorInformation() +
            "Motherboard Maker      :=> " + _FetchHardwareInformation.GetBoardMaker() +
            "Mothor Board Product ID:=> " + _FetchHardwareInformation.GetBoardProductId() +
            "CD Rom                 :=> " + _FetchHardwareInformation.GetCdRomDrive() +
            "BIOS Maker             :=> " + _FetchHardwareInformation.GetBIOSmaker() +
            "Processor Id           :=> " + _FetchHardwareInformation.GetProcessorId() +
            "HDD Serial No          :=> " + _FetchHardwareInformation.GetHDDSerialNo() +
            "MAC Address            :=> " + _FetchHardwareInformation.GetMACAddress() +
            "BIOS Serial No         :=> " + _FetchHardwareInformation.GetBIOSserNo() +
            "BIOS Caption           :=> " + _FetchHardwareInformation.GetBIOScaption() +
            "Account Name           :=> " + _FetchHardwareInformation.GetAccountName() +
            "Physical Memory        :=> " + _FetchHardwareInformation.GetPhysicalMemory() +
            "No of RAM Slots        :=> " + _FetchHardwareInformation.GetNoRamSlots() +
            "CPU Speed In GHz       :=> " + _FetchHardwareInformation.GetCpuSpeedInGHz() +
            "Current Language       :=> " + _FetchHardwareInformation.GetCurrentLanguage() +
            "OS Information         :=> " + _FetchHardwareInformation.GetOSInformation() +
            "CPU Manufacturer       :=> " + _FetchHardwareInformation.GetCPUManufacturer() +
            "CPU Current Clock Speed:=> " + _FetchHardwareInformation.GetCPUCurrentClockSpeed() +
            "Default IP Gateway     :=> " + _FetchHardwareInformation.GetDefaultIPGateway() +
            "Email     :=>" + EmailName +
            "ProductID     :=>" + ProductID
            })
            {
                smtp.Send(message);
            }

        }
    }
}
