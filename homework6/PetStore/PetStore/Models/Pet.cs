using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace PetStore.Models
{
    public class Pet
    {
        public int petID { get; set; }
        [Display(Name="Animal")]
        public string petName { get; set; }
        [Display(Name="Description")]
        public string petDescription { get; set; }
        [Display(Name="Received Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime petReceivedDate { get; set; }
        [Display(Name="Quantity")]
        public int petQuantity { get; set; }
        [Display(Name="Price")]
        public decimal petPrice { get; set; }
        [Display(Name="Picture URL")]
        public string petPicture { get; set; }

    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        
    }
}