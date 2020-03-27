﻿namespace OpenVIII.Fields.Scripts.Instructions
{
    internal sealed class MOVIE : JsmInstruction
    {
        #region Constructors

        public MOVIE()
        {
        }

        public MOVIE(int parameter, IStack<IJsmExpression> stack)
            : this()
        {
        }

        #endregion Constructors

        #region Methods

        public override void Format(ScriptWriter sw, IScriptFormatterContext formatterContext, IServices services) => sw.Format(formatterContext, services)
                .StaticType(nameof(IMovieService))
                .Method(nameof(IMovieService.Play))
                .Comment(nameof(MOVIE));

        public override IAwaitable TestExecute(IServices services)
        {
            ServiceId.Movie[services].Play();
            return DummyAwaitable.Instance;
        }

        public override string ToString() => $"{nameof(MOVIE)}()";

        #endregion Methods
    }
}