using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class MentalHealth : Sections
    {
        public MentalHealth(SectionType type, int MaxBooks) : base(SectionType.MentalHealth, MaxBooks)
        {
            AddBook(new Book("الألعاب النفسية", "Learn to live in the present", 180, "Dr Mohamed Refaat"));
            AddBook(new Book("قوانين التحرر من الصراع النفسي", "Understanding emotional pain", 200, "Dr Youssef Alhosny"));
            AddBook(new Book("ممتلئ بالفراغ", "Building mental strength", 220, "Dr Emad Rashad"));
            AddBook(new Book("جلسات نفسية", "Overcoming anxiety", 190, "Dr Mohamed Ibrahim"));
            AddBook(new Book("مفتقد للحياة", "Finding inner peace", 210, "Dr Mohamed Ibrahim"));
            AddBook(new Book("الخروج عن النص", "يتناول هذا الكتاب رحلة الانسان في فهم ذاته والتخلص من القيود النفسية", 180, "Dr Mohamed Taha"));
        }
    }
}




