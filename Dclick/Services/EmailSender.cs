namespace Dclick.Services
{
    public class EmailSender
    {
        public class Product
        {
            public int Id { get; set; } // Clé primaire
            public string Name { get; set; } // Nom du produit
            public decimal Price { get; set; } // Prix du produit
            public string Description { get; set; } // Description
        }

        public class Contact
        {
            public int Id { get; set; } // Clé primaire
            public string FullName { get; set; } // Nom complet
            public string Email { get; set; } // Email
            public string PhoneNumber { get; set; } // Numéro de téléphone
        }

        public class Attachment
        {
            public int Id { get; set; } // Clé primaire
            public string FileName { get; set; } // Nom du fichier
            public byte[] FileContent { get; set; } // Contenu du fichier (binaire)
            public DateTime UploadDate { get; set; } // Date d'upload
        }

    }
}
