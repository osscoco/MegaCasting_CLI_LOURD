//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaCastingV2.DBlib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidature
    {
        public int Id { get; set; }
        public string Objet { get; set; }
        public string Date_Publication { get; set; }
        public string Description { get; set; }
        public int IdAnnonce { get; set; }
        public int IdArtiste { get; set; }
        public int IdStatut { get; set; }
    
        public virtual Annonce Annonce { get; set; }
        public virtual Artiste Artiste { get; set; }
        public virtual Statut Statut { get; set; }
    }
}
