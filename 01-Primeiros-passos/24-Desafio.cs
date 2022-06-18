//  Inverts a string and counts the number of times a specific character is displayed

string phrase = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = phrase.ToCharArray();
Array.Reverse(charMessage);

int count = 0;
foreach (char letter in charMessage) { if (letter == 'o') { count++; } }

string newMessage = new String(charMessage);

Console.WriteLine($"In {newMessage} 'o' appears {count} times.");