using System.Collections.Generic;

namespace TextAnalysis {
    static class SentencesParserTask {
        public static List<List<string>> ParseSentences(string text) {
            var sentencesList = new List<List<string>>();
            char[] separators = new char[7] { '.', '!', '?', ';', ':', '(', ')' };
            string[] newText = text.Split(separators, System.StringSplitOptions.RemoveEmptyEntries); ;
            foreach( var sentence in newText ) {
                var wordsList = new List<string>();
                if( sentence.Length > 0 || sentence != null ) {
                    string word = "";
                    foreach( char c in sentence.Trim() ) {
                        if( char.IsLetter(c) || c == '\'' || c == '\\' ) word += c;
                        else {
                            if( word != "" ) {
                                wordsList.Add(word.ToLower());
                                word = "";
                                }
                            else continue;
                            }
                        }
                    if( word.Length != 0 && word != "" ) wordsList.Add(word.ToLower());
                    sentencesList.Add(wordsList);
                    }
                else continue;
                }
            sentencesList.RemoveAll(x => x == null || x.Count == 0);
            return sentencesList;
            }
        }
    }
