﻿using static System.Console;
DateTime dateSample = new DateTime(2023, 01, 27);
DateTime timeSample = new DateTime(2023, 01, 27,09,25,53);
DateOnly dateOnlySample = new DateOnly(2023, 01, 27);
TimeOnly timeOnlySample = new TimeOnly(18, 20, 55);
WriteLine(dateSample);
WriteLine(timeSample);
WriteLine(dateOnlySample);
WriteLine(timeOnlySample);

ReadLine();