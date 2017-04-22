﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_sim_game
{
    class CitySimGame
    {
        private static bool paused = false;
        private static bool quit = false;
        private static Map map = null;

        public static void Main(string[] args)
        {
            map = new Map(5, 5);
            System.Threading.Thread timeThread = new System.Threading.Thread(TimePassage);
            timeThread.Start();
            while(!quit)
            {
                string input = Console.ReadLine();
                if(input.Equals("pause"))
                {
                    paused = !paused;
                }
                else if(input.Equals("quit"))
                {
                    quit = true;
                    paused = true;
                    timeThread.Abort();
                }
                else if(input.Equals("zone"))
                {
                    Console.WriteLine("Enter 'new', 'change', 'check', or 'remove': ");
                    input = Console.ReadLine();
                    if(input.Equals("new")){
                        map.NewZone();
                    }
                    else if(input.Equals("check"))
                    {
                        map.CheckZone();
                    }
                    else if(input.Equals("change"))
                    {
                        map.ChangeZone();
                    }
                    else if(input.Equals("remove"))
                    {
                        map.RemoveZone();
                    }
                }
            }
        }

        private static void TimePassage()
        {
            GameTime gt = new GameTime();
            while(!quit)
            {
                while(!paused)
                {
                    gt.Tick();
                    System.Threading.Thread.Sleep(167);
                }
            }
        }
    }
}
