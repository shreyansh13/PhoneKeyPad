# Keypad Phone API
# Introduction
This repository provides an API that simulates the text input functionality of a traditional mobile phone keypad. Given a sequence of digits as input, the API processes the input according to the multi-tap text entry system and returns the corresponding text output.

# API Usage
To use this API, call the following method:

string output = PhoneProcessor.OldPhonePad(input);

# Parameters
The input string should contain digits from 2-9 and the * character.
* Each digit corresponds to a set of characters, similar to old mobile phone keypads:
2 → a, b, c
3 → d, e, f
4 → g, h, i
5 → j, k, l
6 → m, n, o
7 → p, q, r, s
8 → t, u, v
9 → w, x, y, z
* Repeating a digit selects the corresponding character in order. For example:
"2" → "a"
"22" → "b"
"222" → "c"
* A space (" ") in the input separates characters that use the same digit.
"22 2" → "ba"
* A * represents a backspace and deletes the previous character.
"22*2" → "a"
* The last character in the string should always be # to indicate the end of input.

# Output
The function returns the decoded text string based on the provided input.

## Example Usage

string result = PhoneProcessor.OldPhonePad("2233555#");
Output: "BEL"

This API efficiently converts old-style mobile keypad inputs into readable text.

