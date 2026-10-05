using Collections;

Show("01012345678", "01012345678".IsValidEgyptianPhone(), true);
Show("+201512345678", "+201512345678".IsValidEgyptianPhone(), true);
Show("01312345678", "01312345678".IsValidEgyptianPhone(), false);
Show("0101234567", "0101234567".IsValidEgyptianPhone(), false);
Show("0101234567a", "0101234567a".IsValidEgyptianPhone(), false);

Show("29901011234567", "29901011234567".IsValidEgyptianNationalId(), true);
Show("19901011234567", "19901011234567".IsValidEgyptianNationalId(), false);
Show("2990101123456", "2990101123456".IsValidEgyptianNationalId(), false);

string? nothing = null;
Show("null", nothing.IsValidEgyptianPhone(), false);
Show("empty", "".IsValidEgyptianPhone(), false);
Show("space", "   ".IsValidEgyptianPhone(), false);

static void Show(string input, bool actual, bool expected) =>
    Console.WriteLine($"{(actual == expected ? "PASS" : "FAIL")}  {input,-16} -> {actual}");