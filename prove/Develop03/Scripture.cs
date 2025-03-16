using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            string[] parts = text.Split(' ');
            foreach (string part in parts)
            {
                _words.Add(new Word(part));
            }
        }

        public void DisplayScripture()
        {
            Console.WriteLine(_reference.GetFormattedReference());
            Console.WriteLine();

            foreach (Word word in _words)
            {
                Console.Write(word.GetDisplayText() + " ");
            }
            Console.WriteLine();
        }

        public void HideRandomWords(int count)
        {
            List<int> visibleIndices = new List<int>();
            for (int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden)
                {
                    visibleIndices.Add(i);
                }
            }

            if (visibleIndices.Count == 0)
            {
                return;
            }

            if (count > visibleIndices.Count)
            {
                count = visibleIndices.Count;
            }

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(visibleIndices.Count);
                int wordIndex = visibleIndices[randomIndex];

                _words[wordIndex].Hide();
                visibleIndices.RemoveAt(randomIndex);
            }
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden);
        }
    }
}