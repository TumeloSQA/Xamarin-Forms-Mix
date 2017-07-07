using System;
using System.Collections.Generic;
using XamarinFormsMix2.Models;

namespace XamarinFormsMix2.Services
{
    public interface IMonkeyService
    {
        List<Monkey> GetMonkeys(string weburi);
    }
}
