﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Soliders soliders = new Soliders();
            Command combinateCommand = new CombinateCommand(soliders);
            Command fightCommand = new FightCommand(soliders);
            Command cableBoatCommand = new CableBoatCommand(soliders);

            //设置传令官
            Herald herald = new Herald();

            //集合
            herald.SetCommand(combinateCommand);
            //herald.Notify();

            //战斗
            herald.SetCommand(fightCommand);
            herald.SetCommand(fightCommand);
           // herald.Notify();

            //铁索连舟
            herald.SetCommand(cableBoatCommand);
            //herald.Notify();
            herald.Notify();
            Console.WriteLine("取消命令！");
            herald.CancelCommand(cableBoatCommand);
            herald.Notify();

            Reciver reciver = new Reciver();
            AbsCommand command = new ConcreteCommand(reciver);
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
