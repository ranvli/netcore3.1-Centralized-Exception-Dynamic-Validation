using System.ComponentModel.DataAnnotations;

namespace DynamicInputValidation.Controllers
{
    public class Item
    {
        [Range(1,2)]
        public MyEnum MyEnum { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }
    }
}