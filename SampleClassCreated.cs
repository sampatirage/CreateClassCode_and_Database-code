using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteClassCode
{
    public class Laptop
    {
        internal string Condition { get; set; }
        internal string Model { get; set; }
        internal int Memory { get; set; }
        internal string MemoryType { get; set; }
        internal int MaxMemory { get; set; }
        internal string Colour { get; set; }
        internal string OS { get; set; }
        internal float ScreenSize { get; set; }
        internal string Resolution { get; set; }
        internal string Graphics { get; set; }
        internal string StorageType { get; set; }
        internal int StorageSizeGB { get; set; }
        internal string ProcessorName { get; set; }

        internal string ProcessorModel { get; set; }
        internal int ProcessorSpeed { get; set; }
        internal int NoOfCores { get; set; }
        internal bool WebCam { get; set; }
        internal bool CardReader { get; set; }
        internal bool HDMI { get; set; }
        internal int USBPortsTotal { get; set; }
        internal int USB3Ports { get; set; }
        internal bool LAN { get; set; }
        internal string WiFiType { get; set; }
        internal string UPC { get; set; }



        public Laptop(string condition, string model, int memory, string memorytype, int maxmemory, string colour, string os,
            float screensize, string resolution, string graphics, string storagetype, int storagesizegb, string processorname,
            string processormodel, int processorspeed, int noofcores, bool webcam, bool cardreader, bool hdmi, int usbportstotal,
            int usb3ports, bool lan, string wifitype, string upc)
        {
            this.Condition = condition;
            this.Model = model;
            this.Memory = memory;
            this.MemoryType = memorytype;
            this.MaxMemory = maxmemory;
            this.Colour = colour;
            this.OS = os;
            this.ScreenSize = screensize;
            this.Resolution = resolution;
            this.Graphics = graphics;
            this.StorageType = storagetype;
            this.StorageSizeGB = storagesizegb;
            this.ProcessorName = processorname;
            this.ProcessorModel = processormodel;
            this.ProcessorSpeed = processorspeed;
            this.NoOfCores = noofcores;
            this.WebCam = webcam;
            this.CardReader = cardreader;
            this.HDMI = hdmi;
            this.USBPortsTotal = usbportstotal;
            this.USB3Ports = usb3ports;
            this.LAN = lan;
            this.WiFiType = wifitype;
            this.UPC = upc;

        }
    }
}

/*
 * 
 * */
