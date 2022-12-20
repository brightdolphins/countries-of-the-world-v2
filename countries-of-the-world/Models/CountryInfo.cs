using System.ComponentModel.DataAnnotations;

namespace CountriesOfTheWorld.Models {
    public class CountryInfo {
        [Key]
        public int RowId { get; set; }

        [Required(ErrorMessage = "Name field is required Countrycode!")]
        public string Countrycode { get; set; }

        [Required(ErrorMessage = "Name field is required Countryname!")]
        public string Countryname { get; set; }

        [Required(ErrorMessage = "Name field is required Capitalname!")]
        public string Capitalname { get; set; }

        [Required(ErrorMessage = "Name field is required Population!")]
        [Range(0.00, 9999999999.99, ErrorMessage = "Type formating is wrong number")]
        public double Population { get; set; }
        public DateTime? Createddate { get; set; }
        //[NotMapped]
        public DateTime? Modifydate { get; set; }
    }
}
