using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FetchApiSirene.DataAccess.Models
{
    public class Establishments
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement("Registration")]
        public string Registration { get; set; }
        
        [BsonElement("Denomination")]
        public string Denomination { get; set; }
       
        [BsonElement("Address")]
        public string  Address  { get; set;}
        
        [BsonElement("PostalCode")]
        public string PostalCode { get; set;}
        
        [BsonElement("Town")]
        public string Town { get; set;}
        
        [BsonElement("Siren")]
        public string Siren { get; set;}
        
        [BsonElement("Siret")]
        public string Siret { get; set;}
        
        [BsonElement("NafCode")]
        public int NafCode  { get; set;}
       


    }
    
    public class Denomination
    {
        [BsonElement("nomUniteLegale")]
        public string nomUniteLegale { get; set;}

        [BsonElement("prenom1UniteLegale")]
        public string prenom1UniteLegale { get; set; }
        
    }

    public class Adresse
    {
        [BsonElement("NumeroVoieEtablissement")]
        public int NumeroVoieEtablissement { get; set; }
        [BsonElement("IndiceRepetitionEtablissement")]

        public int IndiceRepetitionEtablissement { get;set; }
        [BsonElement("TypeVoieEtablissement")]
        public string TypeVoieEtablissement { get; set; }
        [BsonElement("LibelleVoieEtablissement")]
        public string LibelleVoieEtablissement { get; set; }
        [BsonElement("LibelleCommuneEtablissement")]
        public string LibelleCommuneEtablissement { get; set; }
       
    }
    public class PostalCode
    {
        [BsonElement("CodePostalEtablissement")]
        public int codePostalEtablissement { get; set; }
        
    }

    public class Town
    {
        [BsonElement("LibelleCommuneEtablissement")]
        public string LibelleCommuneEtablissement { get; set; }
        
    }
    public class NafCode
    {
        [BsonElement("ActivitePrincipaleUniteLegale")]
        public string ActivitePrincipaleUniteLegale { get; set; }
        
    }

}
