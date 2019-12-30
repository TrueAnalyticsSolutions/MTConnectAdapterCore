using System.Xml;
using System.Xml.Serialization;

namespace MTConnect {
  /// <summary>
  /// Abstract Asset class.
  /// </summary>
  public abstract class Asset {
    public string AssetId { set; get; }

    public Asset(string id) {
      AssetId = id;
    }

    public virtual XmlWriter ToXml(XmlWriter writer) {
      writer.WriteAttributeString("assetId", AssetId);
      return writer;
    }

    abstract public string GetMTCType();
  }
}
