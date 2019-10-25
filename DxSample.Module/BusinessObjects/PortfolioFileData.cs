using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace DxSample.Module.BusinessObjects {
    public class PortfolioFileData : FileAttachmentBase
    {


        public PortfolioFileData(Session session) : base(session) { }
        private DocumentType documentType;
        protected Resume resume;


        [Persistent, Association("Resume-PortfolioFileData")]
        public Resume Resume {
            get { return resume; }
            set {
                SetPropertyValue("Resume", ref resume, value);
            }
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
            documentType = DocumentType.Unknown;
        }
        public DocumentType DocumentType {
            get { return documentType; }
            set { SetPropertyValue("DocumentType", ref documentType, value); }
        }
    }
    public enum DocumentType {
        SourceCode = 1, Tests = 2, Documentation = 3,
        Diagrams = 4, ScreenShots = 5, Unknown = 6
    };
}
