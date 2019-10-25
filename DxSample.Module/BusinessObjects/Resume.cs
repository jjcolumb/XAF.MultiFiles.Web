using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace DxSample.Module.BusinessObjects {
    [NavigationItem]
    public class Resume : BaseObject {
        public Resume(Session session) : base(session) { }


        string _title;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Title
        {
            get => _title;
            set => SetPropertyValue(nameof(Title), ref _title, value);
        }
        

        [Aggregated, Association("Resume-PortfolioFileData")]
        public XPCollection<PortfolioFileData> Portfolio {
            get { return GetCollection<PortfolioFileData>("Portfolio"); }
        }
    }
}
