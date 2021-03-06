﻿using Bomberman_1.player;
using BomberManProject.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_1.improvement.Chain_of_Responsibility
{
    public class ChainOfBuffs {

        public static AbstractBuffGiver getChainOfBuffs()
        {
            AbstractBuffGiver removeBuff = new BuffRemover(AbstractBuffGiver.NONE);
            AbstractBuffGiver powerBuff = new PowerGiver(AbstractBuffGiver.POWER);
            AbstractBuffGiver countBuff = new CountGiver(AbstractBuffGiver.COUNT);

            removeBuff.setNextBuffGiver(powerBuff);
            powerBuff.setNextBuffGiver(countBuff);

            return removeBuff;
        }

        //Tik testavimas, kaip atrodytu buff'o davimas player'iui
        public void doStuff()
        {
            Player p = new ProxyPlayer();
            AbstractBuffGiver buffChain = getChainOfBuffs();
            p = buffChain.giveBuff(AbstractBuffGiver.COUNT, p);
            Console.WriteLine(p.getImprov().GetType().ToString());
        }
    }
}