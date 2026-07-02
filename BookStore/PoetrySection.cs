using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class PoetrySection : Sections
    {
        public PoetrySection(SectionType type, int maxBooks) : base(SectionType.Poetry, maxBooks)
        {
            AddBook(new Book("الشعر العربي الفصيح", "Nature and emotions", 150, "Mohamed Waheed"));
            AddBook(new Book("لا تعتذر عما فعلت", "Reflections of love", 160, "Mahmoud Darwish"));
            AddBook(new Book("الخنساء", "Poetry of pain and growth", 140, "Hamdo Tammas"));
            AddBook(new Book("الفجر الأول", "Romantic verses", 170, "Khalil Shibob"));
            AddBook(new Book("الشعر العربي", "Hope through words", 155, "Mohamed Abdullah"));
            AddBook(new Book("الصبر كان أيوب", " هو عمل أدبي يتناول مفهوم الصبر من منظور أنساني عميق", 180, "Wael Eid Sayed"));
        }
    }
}





