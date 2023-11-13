using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12Collections
{
    internal class Translator
    {
        private Dictionary<string, string> toRus = new Dictionary<string, string>()
        {
            {"club","клуб" },
            {"age","возраст" },
            {"baby","малыш" },
            {"birth","рождение" },
            {"boy","мальчик" },
            {"child","ребенок" },
            {"childhood","детство" },
            {"buddy","приятель" },
            {"girl","девочка" },
            {"human","человек" },
            {"life","жизнь" },
            {"woman","молодость" },
            {"welcome","добро пожаловать" },
            {"to","к" },
            {"the","тот" },
        };

        private Dictionary<string, string> toEng = new Dictionary<string, string>()
        {
            {"клуб","club" },
            {"возраст","age" },
            {"малыш","baby" },
            {"рождение","birth" },
            {"мальчик","boy" },
            {"ребенок","child" },
            {"детство","childhood" },
            {"приятель","buddy" },
            {"девочка","girl" },
            {"человек","human" },
            {"жизнь","life" },
            {"молодость","woman" },
            {"добро пожаловать","welcome" },
            {"к","to" },
            {"тот","the" },
        };


        public string TranslateToRussian(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (toRus.ContainsKey(words[i]))
                {
                    words[i] = toRus[words[i]];
                }
            }
            return string.Join(" ", words);
        }

        public string TranslateToEnglish(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (toEng.ContainsKey(words[i]))
                {
                    words[i] = toEng[words[i]];
                }
            }
            return string.Join(" ", words);
        }


    }
}
