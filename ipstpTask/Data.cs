using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ipstpTask
{
    internal class Data
    {
        [XmlRoot("nodes")]
        public class Nodes
        {
            [XmlElement("node")]
            public List<Node> Node { get; set; }
        }
        [XmlRoot("node")]
        public class Node
        {
            [XmlText]
            public string Name { get; set; }

            [XmlElement("networkassetdata")]
            public List<NetWorkAsSetData> NetWorkAsSetData { get; set; }
        }

        [XmlRoot("networkassetdata")]
        public class NetWorkAsSetData
        {
            [XmlElement("networkelement")]
            public List<NetWorkElement> NetWorkElements { get; set; }

            [XmlElement("softwarecomponent")]
            public List<SoftwareComponent> SoftwareComponents { get; set; }

            [XmlElement("softconfiguration")]
            public List<SoftConfiguration> SoftConfigurations { get; set; }

            [XmlElement("identity")]
            public List<Identity> Identity { get; set; }    
        }

        [XmlRoot("networkelement")]
        public class NetWorkElement
        {
            [XmlElement("nodetype")]
            public string NddeType { get; set; }

            [XmlElement("opco")]
            public string OPCO { get; set; }

            [XmlElement("oem")]
            public string OEM { get; set; }

            [XmlElement("elementname")]
            public string ElementName { get; set; }

            [XmlElement("softwarereleaseinformation")]
            public string SoftwareReleaseInformation { get; set; }

            [XmlElement("softwareproductnumber")]
            public string SoftwareProductNumber { get; set; }

            [XmlElement("softwareproductdate")]
            public string SoftwareProductDate { get; set; }

            [XmlElement("softwareinstalldate")]
            public string SoftwareInstallDate { get; set; }

            [XmlElement("dataacquisitiondate")]
            public string DataAcquisitionDate { get; set; }

            [XmlElement("sitelocation")]
            public string SiteLocation { get; set; }

            [XmlElement("platformtype")]
            public string PlatformType { get; set; }

            [XmlElement("spare1ossorenm")]
            public string Spare1Ossorenm { get; set; }

            [XmlElement("spare2xmlversion")]
            public string Spare2Xmlversion { get; set; }

        }

        [XmlRoot("softwarecomponent")]
        public class SoftwareComponent
        {
            [XmlElement("opco")]
            public string OPCO { get; set; }
            [XmlElement("oem")]
            public string OEM { get; set; }

            [XmlElement("mainsoftwareversion")]
            public string MainSoftwareVersion { get; set; }

        }

        [XmlRoot("softconfiguration")]
        public class SoftConfiguration
        {
            [XmlElement("opco")]
            public string OPCO { get; set; }

            [XmlElement("elementname")]
            public string ElementName { get; set; }
        }

        [XmlRoot("identity")]
        public class Identity
        {
            [XmlElement("opco")]
            public string OPCO { get; set; }

            [XmlElement("elementname")]
            public string ElementName { get; set; }

            [XmlElement("ipaddress")]
            public string IpAddress { get; set; }

        }
    }

}
