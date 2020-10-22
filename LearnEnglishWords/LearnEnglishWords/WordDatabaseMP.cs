using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LearnEnglishWords
{

    public class WordDatabaseMP
    {
        public List<WordMP> Words;
        public WordDatabaseMP()
        {
            var ListofWords = new List<WordMP>();
            
            P_ADICIONA_HOMOFONES(ListofWords,
@"blip bleep
britches breeches
crick creek
din dean
finned fiend
flit fleet
gip jeep
grist greased
pit peat
sim seam
sip seep
shin sheen
skit skeet
slick sleek
slit sleet
tick teak
tit teat
tizz tease
bid bead
bitch beech
biz bees
chick cheek
chit cheat
dip deep
fist feast
fizz fees
hip heap
kid keyed
pill peel
pip peep
piss peace
sill seal
sim seem
skid skied
skim scheme
till teal
tizz teas
bit beat
bitch beach
itch each
gin gene
grid greed
hid heed
hill he'll
ill eel
kip keep
knit neat
lick leak
lip leap
mill meal
pick peek
piss piece
pitch peach
risen reason
shit sheet
sick seek
sin scene
sin seen
still steel
tin teen
did deed
fill feel
fit feet
grin green
hit heat
is ease
mitt meet
slip sleep
still steal
bin bean
chip cheap
his he's
it eat
sit seat");

            Words = ListofWords.Randomize().ToList();
        }

        private void P_ADICIONA_HOMOFONES(List<WordMP> listofWords, string v)
        {
            foreach (var item in v.Split(Environment.NewLine.ToCharArray()).Where(x => x.Trim() != ""))
            {
                var words = item.Split(' ');

                P_Adiciona_palavra(listofWords, words[0], words[1]);
            }
        }


        private void P_Adiciona_palavra(List<WordMP> listofWords, List<WordMP> lists)
        {
            foreach (var item in lists)
            {
                P_Adiciona_palavra(listofWords, item);
            }
        }

        private void P_Adiciona_palavra(List<WordMP> listofWords, WordMP item)
        {
            P_Adiciona_palavra(listofWords, item.TheWord, item.TheWord2);
        }


        private void P_Adiciona_palavra(List<WordMP> listofWords, string word, string word2)
        {
            if (word.Trim() == "") return;

            listofWords.Add(new WordMP() { TheWord = word.Trim(),TheWord2 = word2.Trim() });
        }
    }

    public class WordMP
    {
        private static readonly Random getrandom = new Random();
        public WordMP() 
        {
            ChosenNumber = Randomize(0,2);
        }

        private int Randomize(int v1, int v2)
        {
            int result = GetRandomNumber(v1,v2);
            Console.WriteLine(result.ToString());
            return result;
            
        }

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        public string TheWord { get; set; }
        public string TheWord2 { get; set; }
        public bool Acertou { get; internal set; }
        public string TheRightWord() 
        { 
            if (ChosenNumber == 0)
            {
                return TheWord;
            }
            else
            {
                return TheWord2;
            }
        }

        private int ChosenNumber;
    }

}