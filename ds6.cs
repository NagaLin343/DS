using System;
using System.Collections.Generic;

namespace DS6
{
    class Program
    {

        public class Coffee
        {

        }

        public enum ProgramistState 
        {
            Idle, Moving, Drinking
        }
       
        public class Programist
        {


            private Coffee m_targetCoffee = null;
            private bool m_atTarget = false;
            private ProgramistState m_state = ProgramistState.Idle;
            private Dictionary<ProgramistState, BaseProgramistState> m_states = new Dictionary<ProgramistState, BaseProgramistState>();
            public Programist()
            {
                m_states.Add(ProgramistState.Idle, new ProgramistIdleState(this));
                m_states.Add(ProgramistState.Moving, new ProgramistMoveState(this));
                m_states.Add(ProgramistState.Drinking, new ProgramistDrinkState(this));

            }

            public void ChangeState(ProgramistState state)
            {
                m_state = state;
            }

            public void FindCoffee()
            {
                m_targetCoffee = new Coffee();
                ChangeState(ProgramistState.Moving);
            }

            public void Move()
            {
               
                ChangeState(ProgramistState.Drinking);

            }

            public void Drink()
            {
                m_targetCoffee = null;
                ChangeState(ProgramistState.Idle);

            }

            public void Update()
            {
               

                m_states[m_state].Update();

            }
            public abstract class BaseProgramistState
            {
                protected readonly Programist m_prog;

                public BaseProgramistState(Programist prog)
                {
                    m_prog = prog;
                }
                public abstract void Update();

            }
            public class ProgramistIdleState : BaseProgramistState 
            {
                public ProgramistIdleState(Programist prog) : base(prog) { }

                public override void Update()
                {
                    m_prog.FindCoffee();
                }
               
            }

            public class ProgramistMoveState : BaseProgramistState 
            {
                public ProgramistMoveState(Programist prog) : base(prog) { }

                public override void Update()
                {
                    m_prog.Move();
                }
               
            }

            public class ProgramistDrinkState : BaseProgramistState 
            {
                public ProgramistDrinkState(Programist prog) : base(prog) { }

                public override void Update()
                {
                    m_prog.Drink();
                }
                
            }

        }
    }
}
