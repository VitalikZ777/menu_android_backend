using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace menu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    [ServiceContract]


    public interface IService1
    {
     [OperationContract(Name = "GetDate")]
        [WebGet(UriTemplate = "/GetMenu/{daten}",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare)]
        List<Menu> GetMenu(string daten);
           
       
            [OperationContract]
            [WebGet(UriTemplate = "/GetMenu",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare)]
        List<Menu> GetMenu();
    }


    [DataContract]
public class Menu
{
 

  [DataMember]
  public DateTime datenn { get; set; }

  [DataMember]
  public string namest1 { get; set; }

  [DataMember]
  public decimal sprice1 { get; set; }

        [DataMember]
        public string namest2 { get; set; }

        [DataMember]
        public decimal sprice2 { get; set; }

        [DataMember]
        public string namest3 { get; set; }

        [DataMember]
        public decimal sprice3 { get; set; }

        [DataMember]
        public string namest4 { get; set; }

        [DataMember]
        public decimal sprice4 { get; set; }

        [DataMember]
        public string namest5 { get; set; }

        [DataMember]
        public decimal sprice5 { get; set; }

        [DataMember]
        public string namest6 { get; set; }

        [DataMember]
        public decimal sprice6 { get; set; }

        [DataMember]
        public string namest7 { get; set; }

        [DataMember]
        public decimal sprice7 { get; set; }

    }
}
