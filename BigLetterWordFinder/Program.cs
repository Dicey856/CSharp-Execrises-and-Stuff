﻿Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(word => word.First() >= 'A' && word.First() <= 'Z')
    .ToList()
    .ForEach(word => Console.WriteLine(word));

