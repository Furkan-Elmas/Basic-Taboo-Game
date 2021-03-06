using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TabooWords : MonoBehaviour
{
    #region Easy Words

    private string[] wE1 = new string[] { "Internet", "computer", "web", "surf", "net", "technology" };
    private string[] wE2 = new string[] { "Jacket", "coat", "warm", "clothes", "sleeves", "zipper" };
    private string[] wE3 = new string[] { "Ice Cream", "cold", "summer", "sweat", "sneak", "cone" };
    private string[] wE4 = new string[] { "Police", "uniform", "safety", "peace", "protect", "siren" };
    private string[] wE5 = new string[] { "Duck", "bird", "yellow", "chicken", "food", "quack quack" };
    private string[] wE6 = new string[] { "Dance", "shoes", "romantic", "music", "sing", "hand" };
    private string[] wE7 = new string[] { "Hungry", "feeling", "eat", "food", "breakfast", "meal" };
    private string[] wE8 = new string[] { "Car", "driver", "ride", "transport", "fast", "travel" };
    private string[] wE9 = new string[] { "Snowboard", "winter", "snow", "fall", "ski", "cold" };
    private string[] wE10 = new string[] { "Tourist", "traveller", "pleasure", "trip", "person", "someone" };
    private string[] wE11 = new string[] { "Chocolate", "cocoa", "candy", "sweet", "black", "snack" };
    private string[] wE12 = new string[] { "Credit Card", "bank", "dept", "interest", "expiry", "contract" };
    private string[] wE13 = new string[] { "Celebration", "party", "birthday", "cake", "success", "promotion" };
    private string[] wE14 = new string[] { "Hospital", "doctor", "injured", "sickness", "illness", "surgery" };
    private string[] wE15 = new string[] { "Warrior", "soldier", "war", "attack", "battle", "sword" };
    private string[] wE16 = new string[] { "Mushroom", "white", "eat", "fungus", "sauce", "high" };
    private string[] wE17 = new string[] { "Jail", "prison", "criminals", "bars", "arrest", "police" };
    private string[] wE18 = new string[] { "Hammer", "thor", "swing", "build", "tool", "nail" };
    private string[] wE19 = new string[] { "Donkey", "gray", "cart", "stubborn", "ride", "animal" };
    private string[] wE20 = new string[] { "Pirate", "caribbean", "ship", "jack sparrow", "captain hook", "rum" };
    private string[] wE21 = new string[] { "Barber", "haircut", "shave", "scissors", "hairdresser", "comb" };
    private string[] wE22 = new string[] { "Cigarette", "pipe", "smoke", "tobacco", "lungs", "cancer" };
    private string[] wE23 = new string[] { "Star", "sun", "bright", "space", "yellow", "night" };
    private string[] wE24 = new string[] { "King", "queen", "prince", "leader", "crown", "throne" };
    private string[] wE25 = new string[] { "Gym", "bodybuilding", "weights", "work out", "sweat", "exercise" };
    private string[] wE26 = new string[] { "Mouse", "keyboard", "computer", "equipment", "click", "rat" };
    private string[] wE27 = new string[] { "Milk", "cow", "kids", "white", "pasteurized", "drink" };
    private string[] wE28 = new string[] { "Hair", "head", "black", "long", "cut", "bald" };
    private string[] wE29 = new string[] { "Picture", "paint", "image", "photo", "draw", "view" };
    private string[] wE30 = new string[] { "Camera", "phone", "action", "photo", "video", "record" };
    private string[] wE31 = new string[] { "Dark", "black", "shadow", "light", "bright", "night" };
    private string[] wE32 = new string[] { "Pencil", "write", "paper", "eraser", "book", "school" };
    private string[] wE33 = new string[] { "Tea", "cup", "leaf", "hot", "juice", "sugar" };
    private string[] wE34 = new string[] { "Game", "play", "fun", "enjoy", "competition", "time" };
    private string[] wE35 = new string[] { "Time", "clock", "watch", "hour", "minute", "second" };
    private string[] wE36 = new string[] { "Love", "like", "couple", "heart", "marriage", "engagement" };
    private string[] wE37 = new string[] { "Knife", "cut", "stab", "chop", "murder", "kill" };
    private string[] wE38 = new string[] { "Fork", "kitchen", "spoon", "meal", "spagetti", "food" };
    private string[] wE39 = new string[] { "Vegetable", "plant", "healthy", "tomatoe", "fruit", "green" };
    private string[] wE40 = new string[] { "Forget", "remind", "remember", "memory", "alzheimer", "amnesia" };
    private string[] wE41 = new string[] { "Computer", "hardware", "software", "keyboard", "mouse", "machine" };
    private string[] wE42 = new string[] { "T-shirt", "casual", "comfort", "summer", "short", "hot" };
    private string[] wE43 = new string[] { "Sun", "light", "hot", "moon", "day", "star" };
    private string[] wE44 = new string[] { "Moon", "sun", "night", "light", "white", "ocean" };
    private string[] wE45 = new string[] { "Gold", "silver", "valuable", "investment", "money", "mine" };
    private string[] wE46 = new string[] { "Soldier", "war", "weapon", "army", "discipline", "uniform" };
    private string[] wE47 = new string[] { "Water", "need", "life", "rain", "sea", "ocean" };
    private string[] wE48 = new string[] { "Fire", "light", "warm", "red", "water", "burn" };
    private string[] wE49 = new string[] { "Paper", "pen", "tree", "white", "write", "book" };
    private string[] wE50 = new string[] { "Baby", "little", "cry", "milk", "mother", "father" };

    #endregion

    #region Medium Words

    private string[] wM1 = new string[] { "Shower", "rain", "clean", "water", "every day", "bath" };
    private string[] wM2 = new string[] { "Wind", "blow", "autumn", "invisible", "trees", "kite" };
    private string[] wM3 = new string[] { "Church", "sing", "building", "cross", "god", "jesus" };
    private string[] wM4 = new string[] { "Guide", "job", "person", "someone", "tourist", "show" };
    private string[] wM5 = new string[] { "Letter", "message", "words", "love", "email", "write" };
    private string[] wM6 = new string[] { "Helmet", "fireman", "head", "war", "protection", "hat" };
    private string[] wM7 = new string[] { "Shave", "machine", "razor", "beard", "moustache", "gillette" };
    private string[] wM8 = new string[] { "Bells", "church", "ring", "chime", "ding dong", "jinle" };
    private string[] wM9 = new string[] { "Battery", "electricity", "low", "laptop", "phone", "charge" };
    private string[] wM10 = new string[] { "Makeup", "woman", "lipstick", "pretty", "put on", "beautiful" };
    private string[] wM11 = new string[] { "Owl", "night", "bird", "hoot", "tree", "who who" };
    private string[] wM12 = new string[] { "Company", "business", "corporation", "work", "employer", "partnership" };
    private string[] wM13 = new string[] { "Blood", "red", "cut", "vein", "heart", "body" };
    private string[] wM14 = new string[] { "Printer", "paper", "computer", "machine", "copy", "output" };
    private string[] wM15 = new string[] { "Wizard", "hocus pocus", "magic", "sorcerer", "mage", "illusionist" };
    private string[] wM16 = new string[] { "Tornado", "storm", "wind", "damage", "hurricane", "disaster" };
    private string[] wM17 = new string[] { "Bubble", "gum", "soap", "blow", "pop", "air" };
    private string[] wM18 = new string[] { "Lottery", "win", "money", "ticket", "gambling", "rich" };
    private string[] wM19 = new string[] { "Microwave", "heat", "food", "fast", "cook", "oven" };
    private string[] wM20 = new string[] { "Gem", "precious", "diamond", "value", "jewel", "ring" };
    private string[] wM21 = new string[] { "Insane", "crazy", "mad", "medical", "unfit", "handicap" };
    private string[] wM22 = new string[] { "Torch", "olympics", "fire", "run", "hold", "light" };
    private string[] wM23 = new string[] { "Bait", "fish", "attract", "fly", "worm", "rod" };
    private string[] wM24 = new string[] { "Bald", "hair", "old", "head", "man", "loose" };
    private string[] wM25 = new string[] { "Station", "police", "train", "place", "wait", "track" };
    private string[] wM26 = new string[] { "Town", "city", "small", "country", "place", "ghost" };
    private string[] wM27 = new string[] { "Slim", "fit", "thin", "skinny", "diet", "weight" };
    private string[] wM28 = new string[] { "Boring", "interesting", "sleepy", "alert", "long", "lecture" };
    private string[] wM29 = new string[] { "Lost", "found", "look", "search", "gone", "missing" };
    private string[] wM30 = new string[] { "Volume", "mass", "pitch", "tune", "music", "loud" };
    private string[] wM31 = new string[] { "Mayor", "study", "politician", "city", "town", "govern" };
    private string[] wM32 = new string[] { "Exotic", "unusual", "uncommon", "fruit", "foreign", "rare" };
    private string[] wM33 = new string[] { "Lightning", "electricity", "storm", "thunder", "strike", "flash" };
    private string[] wM34 = new string[] { "Mass", "volume", "bulk", "body", "multitude", "GYM" };
    private string[] wM35 = new string[] { "Boil", "hot", "water", "degrees", "bubble", "pot" };
    private string[] wM36 = new string[] { "Lake", "water", "mass", "lagoon", "ice-skate", "river" };
    private string[] wM37 = new string[] { "Subway", "train", "underground", "transportation", "surfer", "sandwich" };
    private string[] wM38 = new string[] { "News", "agenda", "information", "TV", "report", "daily" };
    private string[] wM39 = new string[] { "Air Conditioner", "cool", "hot", "summer", "cold", "comfort" };
    private string[] wM40 = new string[] { "Patriot", "homelander", "nationalist", "country", "motherland", "native" };

    #endregion

    #region Hard Words

    private string[] wH1 = new string[] { "Foreigner", "teacher", "different", "outside", "country", "travel" };
    private string[] wH2 = new string[] { "Pride", "fall", "lion", "proud", "help", "refuse" };
    private string[] wH3 = new string[] { "Society", "ethics", "people", "language", "race", "religion" };
    private string[] wH4 = new string[] { "Hardware", "machine", "computer", "software", "equipment", "case" };
    private string[] wH5 = new string[] { "Myth", "greek", "legend", "history", "culture", "egypt" };
    private string[] wH6 = new string[] { "Jaw", "mouth", "teeth", "bones", "chew", "tongue" };
    private string[] wH7 = new string[] { "Border", "between", "country", "limit", "line", "neighboor" };
    private string[] wH8 = new string[] { "Tragedy", "terrible", "disaster", "victim", "sad", "people" };
    private string[] wH9 = new string[] { "Prescription", "doctor", "paper", "medicine", "pharmacy", "sick" };
    private string[] wH10 = new string[] { "Corruption", "politician", "bribe", "government", "scandal", "public" };
    private string[] wH11 = new string[] { "Spread", "disease", "virus", "infection", "prevent", "covid" };
    private string[] wH12 = new string[] { "Sacrifice", "human", "kill", "ritual", "blood", "victim" };
    private string[] wH13 = new string[] { "Blizzard", "snow", "cold", "weather", "storm", "winter" };
    private string[] wH14 = new string[] { "Shovel", "dig", "hole", "pit", "shed", "snow" };
    private string[] wH15 = new string[] { "Nun", "catholic", "woman", "priest", "sister", "holy" };
    private string[] wH16 = new string[] { "Fragile", "delicate", "break", "glass", "careful", "sensitive" };
    private string[] wH17 = new string[] { "Hike", "walk", "woods", "mountain", "backpack", "pace" };
    private string[] wH18 = new string[] { "Mansion", "house", "home", "live", "expensive", "luxury" };
    private string[] wH19 = new string[] { "Cooperate", "together", "everyone", "unite", "work", "associate" };
    private string[] wH20 = new string[] { "Ankle", "sprain", "leg", "foot", "break", "disability" };
    private string[] wH21 = new string[] { "Suburb", "city", "outside", "quiet", "live", "urban" };
    private string[] wH22 = new string[] { "Lawn", "grass", "mow", "green", "yard", "tall" };
    private string[] wH23 = new string[] { "Thrifty", "cheap", "spend", "money", "stingy", "saving" };
    private string[] wH24 = new string[] { "Measurement", "unit", "distance", "height", "length", "width" };
    private string[] wH25 = new string[] { "Technical", "foul", "gritty", "correct", "aspect", "time" };
    private string[] wH26 = new string[] { "Niece", "nephew", "aunt", "uncle", "girl", "daughter" };
    private string[] wH27 = new string[] { "Innovative", "new", "original", "found", "modern", "contemporary" };
    private string[] wH28 = new string[] { "Vanish", "disappear", "finish", "end", "go away", "fade" };
    private string[] wH29 = new string[] { "Eulogy", "funeral", "death", "testimony", "story", "speech" };
    private string[] wH30 = new string[] { "Bizarre", "odd", "weird", "strange", "crazy", "different" };
    private string[] wH31 = new string[] { "Hoax", "lie", "false", "true", "cheat", "trick" };
    private string[] wH32 = new string[] { "Affordable", "price", "money", "expensive", "buy", "spend" };
    private string[] wH33 = new string[] { "Drowsy", "sleepy", "drug", "tired", "yawn", "doze" };
    private string[] wH34 = new string[] { "Colleag", "friend", "work", "together", "group", "job" };
    private string[] wH35 = new string[] { "Resume", "curriculum", "statement", "story", "summery", "life" };
    private string[] wH36 = new string[] { "Style", "fashion", "clothes", "wear", "manner", "way" };
    private string[] wH37 = new string[] { "Handicap", "disabled", "impaired", "wheelchair", "help", "assistance" };
    private string[] wH38 = new string[] { "Asylum Seeker", "refugee", "escape", "war", "migrant", "fugitive" };

    #endregion

    [SerializeField] private Text mainWord, tabooWord1, tabooWord2, tabooWord3, tabooWord4, tabooWord5;
    [SerializeField] private Text team, scoretext, passButtonText;
    [SerializeField] private Image pass;

    // Creating list and array objects for each difficulties
    // List objects are for saving the randomly generated index number
    // Arrays are for saving the words

    private List<int> _easyWordIndex = new List<int>();
    private string[][] _easyWords = new string[50][];

    private List<int> _mediumWordIndex = new List<int>();
    private string[][] _mediumWords = new string[40][];


    private List<int> _hardWordIndex = new List<int>();
    private string[][] _hardWords = new string[38][];

    private int _score, _counter;
    private int _passRight, _randomWord, _savedListCount, _savedRandomWord, _lastSavedIndex;
    private string _difficulty;


    public void Start()
    {
        // Taking pass-right and difficulty from settings scene

        _passRight = PlayerPrefs.GetInt("passright");
        _difficulty = PlayerPrefs.GetString("difficulty");
        passButtonText.text = "Pass (" + _passRight + ")";

        // Creating 'if' blocks for each difficulties

        if (_difficulty == "Easy")
        {
            // Taking last seen word's index so as not to repeat
            // Taking last saved list count

            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");
            _savedListCount = PlayerPrefs.GetInt("wordcounteasy");

            // Taking and adding all saved indexes to available list

            for (int i = 0; i < _savedListCount; i++)
            {
                _savedRandomWord = PlayerPrefs.GetInt("wordindexeasy" + i);
                _easyWordIndex.Add(_savedRandomWord);
            }

            _easyWords = new string[][] { wE1, wE2, wE3, wE4, wE5, wE6, wE7, wE8, wE9, wE10, wE11, wE12, wE13, wE14, wE15, wE16, wE17, wE18, wE19, wE20, wE21, wE22, wE23,
                wE24, wE25, wE26, wE27, wE28, wE29, wE30, wE31, wE32, wE33, wE34, wE35, wE36, wE37, wE38, wE39, wE40,wE41, wE42,wE43,wE44,wE45,wE46,wE47,wE48,wE49,wE50 };

            _randomWord = Random.Range(0, _easyWords.Length);

            while (_easyWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _easyWords.Length);
            }

            while (_easyWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _easyWords.Length);
            }

            if (!_easyWordIndex.Contains(_randomWord))
            {
                _easyWordIndex.Add(_randomWord);
                mainWord.text = _easyWords[_randomWord][0];
                tabooWord1.text = _easyWords[_randomWord][1];
                tabooWord2.text = _easyWords[_randomWord][2];
                tabooWord3.text = _easyWords[_randomWord][3];
                tabooWord4.text = _easyWords[_randomWord][4];
                tabooWord5.text = _easyWords[_randomWord][5];

                // Clears the list if all words are taken 

                if (_easyWordIndex.Count == _easyWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _easyWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcounteasy", _easyWordIndex.Count);

            for (int i = 0; i < _easyWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexeasy" + i, _easyWordIndex[i]);
            }
        }

        if (_difficulty == "Medium")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");
            _savedListCount = PlayerPrefs.GetInt("wordcountmedium");

            for (int i = 0; i < _savedListCount; i++)
            {
                _savedRandomWord = PlayerPrefs.GetInt("wordindexmedium" + i);
                _mediumWordIndex.Add(_savedRandomWord);
            }

            _mediumWords = new string[][] { wM1, wM2, wM3, wM4, wM5, wM6, wM7, wM8, wM9, wM10, wM11, wM12, wM13, wM14, wM15, wM16, wM17, wM18, wM19, wM20, wM21, wM22, wM23,
                wM24, wM25, wM26, wM27, wM28, wM29, wM30, wM31, wM32, wM33, wM34, wM35, wM36, wM37,wM38 ,wM39 ,wM40 };

            _randomWord = Random.Range(0, _mediumWords.Length);

            while (_lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _mediumWords.Length);
            }

            while (_mediumWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _mediumWords.Length);
            }
            if (!_mediumWordIndex.Contains(_randomWord))
            {
                _mediumWordIndex.Add(_randomWord);

                mainWord.text = _mediumWords[_randomWord][0];
                tabooWord1.text = _mediumWords[_randomWord][1];
                tabooWord2.text = _mediumWords[_randomWord][2];
                tabooWord3.text = _mediumWords[_randomWord][3];
                tabooWord4.text = _mediumWords[_randomWord][4];
                tabooWord5.text = _mediumWords[_randomWord][5];

                if (_mediumWordIndex.Count == _mediumWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _mediumWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcountmedium", _mediumWordIndex.Count);

            for (int i = 0; i < _mediumWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexmedium" + i, _mediumWordIndex[i]);
            }

        }

        if (_difficulty == "Hard")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");
            _savedListCount = PlayerPrefs.GetInt("wordcounthard");

            for (int i = 0; i < _savedListCount; i++)
            {
                _savedRandomWord = PlayerPrefs.GetInt("wordindexhard" + i);
                _hardWordIndex.Add(_savedRandomWord);
            }

            _hardWords = new string[][] { wH1, wH2, wH3, wH4, wH5, wH6, wH7, wH8, wH9, wH10, wH11, wH12, wH13, wH14, wH15, wH16, wH17, wH18, wH19, wH20, wH21, wH22, wH23,
                wH24, wH25, wH26, wH27, wH28, wH29, wH30, wH31, wH32, wH33, wH34, wH35, wH36, wH37, wH38 };

            _randomWord = Random.Range(0, _hardWords.Length);

            while (_hardWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _hardWords.Length);
            }

            while (_hardWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _hardWords.Length);
            }
            if (!_hardWordIndex.Contains(_randomWord))
            {
                _hardWordIndex.Add(_randomWord);

                mainWord.text = _hardWords[_randomWord][0];
                tabooWord1.text = _hardWords[_randomWord][1];
                tabooWord2.text = _hardWords[_randomWord][2];
                tabooWord3.text = _hardWords[_randomWord][3];
                tabooWord4.text = _hardWords[_randomWord][4];
                tabooWord5.text = _hardWords[_randomWord][5];

                if (_hardWordIndex.Count == _hardWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _hardWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcounthard", _hardWordIndex.Count);

            for (int i = 0; i < _hardWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexhard" + i, _hardWordIndex[i]);
            }
        }
    }

    public void correctButton()
    {
        if (_difficulty == "Easy")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            _score = PlayerPrefs.GetInt("gamescore");
            _score++;
            PlayerPrefs.SetInt("gamescore", _score);

            scoretext.text = _score.ToString();

            _randomWord = Random.Range(0, _easyWords.Length);

            while (_easyWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _easyWords.Length);
            }

            while (_easyWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _easyWords.Length);
            }

            if (!_easyWordIndex.Contains(_randomWord))
            {
                _easyWordIndex.Add(_randomWord);

                mainWord.text = _easyWords[_randomWord][0];
                tabooWord1.text = _easyWords[_randomWord][1];
                tabooWord2.text = _easyWords[_randomWord][2];
                tabooWord3.text = _easyWords[_randomWord][3];
                tabooWord4.text = _easyWords[_randomWord][4];
                tabooWord5.text = _easyWords[_randomWord][5];

                if (_easyWordIndex.Count == _easyWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _easyWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcounteasy", _easyWordIndex.Count);

            for (int i = 0; i < _easyWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexeasy" + i, _easyWordIndex[i]);
            }
        }

        if (_difficulty == "Medium")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            _score = PlayerPrefs.GetInt("gamescore");
            _score++;
            PlayerPrefs.SetInt("gamescore", _score);

            scoretext.text = _score.ToString();

            _randomWord = Random.Range(0, _mediumWords.Length);

            while (_mediumWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _mediumWords.Length);
            }

            while (_mediumWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _mediumWords.Length);
            }
            if (!_mediumWordIndex.Contains(_randomWord))
            {
                _mediumWordIndex.Add(_randomWord);

                mainWord.text = _mediumWords[_randomWord][0];
                tabooWord1.text = _mediumWords[_randomWord][1];
                tabooWord2.text = _mediumWords[_randomWord][2];
                tabooWord3.text = _mediumWords[_randomWord][3];
                tabooWord4.text = _mediumWords[_randomWord][4];
                tabooWord5.text = _mediumWords[_randomWord][5];

                if (_mediumWordIndex.Count == _mediumWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _mediumWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcountmedium", _mediumWordIndex.Count);

            for (int i = 0; i < _mediumWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexmedium" + i, _mediumWordIndex[i]);

            }
        }

        if (_difficulty == "Hard")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            _score = PlayerPrefs.GetInt("gamescore");
            _score++;
            PlayerPrefs.SetInt("gamescore", _score);

            scoretext.text = _score.ToString();

            _randomWord = Random.Range(0, _hardWords.Length);

            while (_hardWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _hardWords.Length);
            }

            while (_hardWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _hardWords.Length);
            }
            if (!_hardWordIndex.Contains(_randomWord))
            {
                _hardWordIndex.Add(_randomWord);

                mainWord.text = _hardWords[_randomWord][0];
                tabooWord1.text = _hardWords[_randomWord][1];
                tabooWord2.text = _hardWords[_randomWord][2];
                tabooWord3.text = _hardWords[_randomWord][3];
                tabooWord4.text = _hardWords[_randomWord][4];
                tabooWord5.text = _hardWords[_randomWord][5];

                if (_hardWordIndex.Count == _hardWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _hardWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcounthard", _hardWordIndex.Count);

            for (int i = 0; i < _hardWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexhard" + i, _hardWordIndex[i]);
            }
        }
    }

    public void tabooButton()
    {
        if (_difficulty == "Easy")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            _score = PlayerPrefs.GetInt("gamescore");
            _score--;
            PlayerPrefs.SetInt("gamescore", _score);

            scoretext.text = _score.ToString();

            _randomWord = Random.Range(0, _easyWords.Length);

            while (_easyWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _easyWords.Length);
            }

            while (_easyWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _easyWords.Length);
            }

            if (!_easyWordIndex.Contains(_randomWord))
            {
                _easyWordIndex.Add(_randomWord);

                mainWord.text = _easyWords[_randomWord][0];
                tabooWord1.text = _easyWords[_randomWord][1];
                tabooWord2.text = _easyWords[_randomWord][2];
                tabooWord3.text = _easyWords[_randomWord][3];
                tabooWord4.text = _easyWords[_randomWord][4];
                tabooWord5.text = _easyWords[_randomWord][5];

                if (_easyWordIndex.Count == _easyWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _easyWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcounteasy", _easyWordIndex.Count);

            for (int i = 0; i < _easyWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexeasy" + i, _easyWordIndex[i]);
            }
        }

        if (_difficulty == "Medium")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            _score = PlayerPrefs.GetInt("gamescore");
            _score--;
            PlayerPrefs.SetInt("gamescore", _score);

            scoretext.text = _score.ToString();

            _randomWord = Random.Range(0, _mediumWords.Length);

            while (_mediumWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _mediumWords.Length);
            }

            while (_mediumWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _mediumWords.Length);
            }
            if (!_mediumWordIndex.Contains(_randomWord))
            {
                _mediumWordIndex.Add(_randomWord);

                mainWord.text = _mediumWords[_randomWord][0];
                tabooWord1.text = _mediumWords[_randomWord][1];
                tabooWord2.text = _mediumWords[_randomWord][2];
                tabooWord3.text = _mediumWords[_randomWord][3];
                tabooWord4.text = _mediumWords[_randomWord][4];
                tabooWord5.text = _mediumWords[_randomWord][5];

                if (_mediumWordIndex.Count == _mediumWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _mediumWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcountmedium", _mediumWordIndex.Count);

            for (int i = 0; i < _mediumWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexmedium" + i, _mediumWordIndex[i]);

            }
        }

        if (_difficulty == "Hard")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            _score = PlayerPrefs.GetInt("gamescore");
            _score--;
            PlayerPrefs.SetInt("gamescore", _score);

            scoretext.text = _score.ToString();

            _randomWord = Random.Range(0, _hardWords.Length);

            while (_hardWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
            {
                _randomWord = Random.Range(0, _hardWords.Length);
            }

            while (_hardWordIndex.Contains(_randomWord))
            {
                _randomWord = Random.Range(0, _hardWords.Length);
            }
            if (!_hardWordIndex.Contains(_randomWord))
            {
                _hardWordIndex.Add(_randomWord);

                mainWord.text = _hardWords[_randomWord][0];
                tabooWord1.text = _hardWords[_randomWord][1];
                tabooWord2.text = _hardWords[_randomWord][2];
                tabooWord3.text = _hardWords[_randomWord][3];
                tabooWord4.text = _hardWords[_randomWord][4];
                tabooWord5.text = _hardWords[_randomWord][5];

                if (_hardWordIndex.Count == _hardWords.Length)
                {
                    PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                    _hardWordIndex.Clear();
                }
            }

            PlayerPrefs.SetInt("wordcounthard", _hardWordIndex.Count);

            for (int i = 0; i < _hardWordIndex.Count; i++)
            {
                PlayerPrefs.SetInt("wordindexhard" + i, _hardWordIndex[i]);
            }
        }
    }

    public void passButton()
    {
        if (_difficulty == "Easy")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            if (_counter != _passRight)
            {
                _randomWord = Random.Range(0, _easyWords.Length);

                while (_easyWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
                {
                    _randomWord = Random.Range(0, _easyWords.Length);
                }

                while (_easyWordIndex.Contains(_randomWord))
                {
                    _randomWord = Random.Range(0, _easyWords.Length);
                }
                if (!_easyWordIndex.Contains(_randomWord))
                {
                    _easyWordIndex.Add(_randomWord);

                    mainWord.text = _easyWords[_randomWord][0];
                    tabooWord1.text = _easyWords[_randomWord][1];
                    tabooWord2.text = _easyWords[_randomWord][2];
                    tabooWord3.text = _easyWords[_randomWord][3];
                    tabooWord4.text = _easyWords[_randomWord][4];
                    tabooWord5.text = _easyWords[_randomWord][5];

                    if (_easyWordIndex.Count == _easyWords.Length)
                    {
                        PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                        _easyWordIndex.Clear();
                    }
                }

                for (int i = 0; i < _easyWordIndex.Count; i++)
                {
                    PlayerPrefs.SetInt("wordindexeasy" + i, _easyWordIndex[i]);
                }
                PlayerPrefs.SetInt("wordcounteasy", _easyWordIndex.Count);

                _counter++;
                passButtonText.text = "Pass (" + (_passRight - _counter) + ")";

                if (_counter == _passRight)
                {
                    pass.GetComponent<Button>().enabled = false;
                    pass.GetComponent<EventTrigger>().enabled = false;

                    Color buttonColor = pass.color;
                    Color textColor = passButtonText.color;

                    buttonColor.r = 0.3490566f;
                    buttonColor.g = 0.3490566f;
                    buttonColor.b = 0.3490566f;
                    buttonColor.a = 0.6f;

                    textColor.a = 0.6f;

                    pass.color = buttonColor;
                    passButtonText.color = textColor;
                }
            }
        }
        if (_difficulty == "Medium")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            if (_counter != _passRight)
            {
                _randomWord = Random.Range(0, _mediumWords.Length);

                while (_mediumWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
                {
                    _randomWord = Random.Range(0, _mediumWords.Length);
                }

                while (_mediumWordIndex.Contains(_randomWord))
                {
                    _randomWord = Random.Range(0, _mediumWords.Length);
                }
                if (!_mediumWordIndex.Contains(_randomWord))
                {
                    _mediumWordIndex.Add(_randomWord);

                    mainWord.text = _mediumWords[_randomWord][0];
                    tabooWord1.text = _mediumWords[_randomWord][1];
                    tabooWord2.text = _mediumWords[_randomWord][2];
                    tabooWord3.text = _mediumWords[_randomWord][3];
                    tabooWord4.text = _mediumWords[_randomWord][4];
                    tabooWord5.text = _mediumWords[_randomWord][5];

                    if (_mediumWordIndex.Count == _mediumWords.Length)
                    {
                        PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                        _mediumWordIndex.Clear();
                    }
                }

                for (int i = 0; i < _mediumWordIndex.Count; i++)
                {
                    PlayerPrefs.SetInt("wordindexmedium" + i, _mediumWordIndex[i]);
                }
                PlayerPrefs.SetInt("wordcountmedium", _mediumWordIndex.Count);

                _counter++;
                passButtonText.text = "Pass (" + (_passRight - _counter) + ")";

                if (_counter == _passRight)
                {
                    pass.GetComponent<Button>().enabled = false;
                    pass.GetComponent<EventTrigger>().enabled = false;

                    Color buttonColor = pass.color;
                    Color textColor = passButtonText.color;

                    buttonColor.r = 0.3490566f;
                    buttonColor.g = 0.3490566f;
                    buttonColor.b = 0.3490566f;
                    buttonColor.a = 0.6f;

                    textColor.a = 0.6f;

                    pass.color = buttonColor;
                    passButtonText.color = textColor;
                }
            }
        }
        if (_difficulty == "Hard")
        {
            _lastSavedIndex = PlayerPrefs.GetInt("lastsavedindex");

            if (_counter != _passRight)
            {
                _randomWord = Random.Range(0, _hardWords.Length);

                while (_hardWordIndex.Count == 0 && _lastSavedIndex == _randomWord)
                {
                    _randomWord = Random.Range(0, _hardWords.Length);
                }

                while (_hardWordIndex.Contains(_randomWord))
                {
                    _randomWord = Random.Range(0, _hardWords.Length);
                }
                if (!_hardWordIndex.Contains(_randomWord))
                {
                    _hardWordIndex.Add(_randomWord);

                    mainWord.text = _hardWords[_randomWord][0];
                    tabooWord1.text = _hardWords[_randomWord][1];
                    tabooWord2.text = _hardWords[_randomWord][2];
                    tabooWord3.text = _hardWords[_randomWord][3];
                    tabooWord4.text = _hardWords[_randomWord][4];
                    tabooWord5.text = _hardWords[_randomWord][5];

                    if (_hardWordIndex.Count == _hardWords.Length)
                    {
                        PlayerPrefs.SetInt("lastsavedindex", _randomWord);
                        _hardWordIndex.Clear();
                    }
                }

                for (int i = 0; i < _hardWordIndex.Count; i++)
                {
                    PlayerPrefs.SetInt("wordindexhard" + i, _hardWordIndex[i]);
                }
                PlayerPrefs.SetInt("wordcounthard", _hardWordIndex.Count);

                _counter++;
                passButtonText.text = "Pass (" + (_passRight - _counter) + ")";

                if (_counter == _passRight)
                {
                    pass.GetComponent<Button>().enabled = false;
                    pass.GetComponent<EventTrigger>().enabled = false;

                    Color buttonColor = pass.color;
                    Color textColor = passButtonText.color;

                    buttonColor.r = 0.3490566f;
                    buttonColor.g = 0.3490566f;
                    buttonColor.b = 0.3490566f;
                    buttonColor.a = 0.6f;

                    textColor.a = 0.6f;

                    pass.color = buttonColor;
                    passButtonText.color = textColor;
                }
            }
        }

    }
}
