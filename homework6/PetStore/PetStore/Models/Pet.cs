using System;
using System.Data.Entity;

namespace PetStore.Models
{
    public class Pet
    {
        public int petID { get; set; }
        public string petName { get; set; }
        public string petDescription { get; set; }
        public DateTime petReceivedDate { get; set; }
        public int petQuantity { get; set; }
        public decimal petPrice { get; set; }
        public byte petPicture { get; set; }

    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        
    }
}