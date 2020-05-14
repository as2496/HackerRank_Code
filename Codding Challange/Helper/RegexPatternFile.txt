Only letters:

Regex.IsMatch(input, @"^[a-zA-Z]+$");

OR

bool result = input.All(Char.IsLetter);



Only letters and numbers:

Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");

OR

bool result = input.All(Char.IsLetterOrDigit);

Only letters, numbers and underscore:

Regex.IsMatch(input, @"^[a-zA-Z0-9_]+$");

OR
bool result = input.All(c => Char.IsLetterOrDigit(c) || c == '_');


Letters only:

Regex.IsMatch(theString, @"^[\p{L}]+$");
Letters and numbers:

Regex.IsMatch(theString, @"^[\p{L}\p{N}]+$");
Letters, numbers and underscore:

Regex.IsMatch(theString, @"^[\w]+$");
Note, these patterns also match international characters(as opposed to using the a-z construct).