

using System.ComponentModel.DataAnnotations;

namespace text_editor_kullanımı.Models
{
    public class Makale 
    {
        [Key]
        public int Id { get; set; }
        public string  Baslik{ get; set; }
        public string  Name{ get; set; }
        public string  Text{ get; set; }
        public string  Tarih{ get; set; }
        


    }
}
