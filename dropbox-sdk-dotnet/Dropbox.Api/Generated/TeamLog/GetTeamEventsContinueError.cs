// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Errors that can be raised when calling <see
    /// cref="Dropbox.Api.TeamLog.Routes.TeamLogTeamRoutes.GetEventsContinueAsync" />.</para>
    /// </summary>
    public class GetTeamEventsContinueError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetTeamEventsContinueError> Encoder = new GetTeamEventsContinueErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetTeamEventsContinueError> Decoder = new GetTeamEventsContinueErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetTeamEventsContinueError" />
        /// class.</para>
        /// </summary>
        public GetTeamEventsContinueError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is BadCursor</para>
        /// </summary>
        public bool IsBadCursor
        {
            get
            {
                return this is BadCursor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a BadCursor, or <c>null</c>.</para>
        /// </summary>
        public BadCursor AsBadCursor
        {
            get
            {
                return this as BadCursor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Reset</para>
        /// </summary>
        public bool IsReset
        {
            get
            {
                return this is Reset;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Reset, or <c>null</c>.</para>
        /// </summary>
        public Reset AsReset
        {
            get
            {
                return this as Reset;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetTeamEventsContinueError" />.</para>
        /// </summary>
        private class GetTeamEventsContinueErrorEncoder : enc.StructEncoder<GetTeamEventsContinueError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetTeamEventsContinueError value, enc.IJsonWriter writer)
            {
                if (value is BadCursor)
                {
                    WriteProperty(".tag", "bad_cursor", writer, enc.StringEncoder.Instance);
                    BadCursor.Encoder.EncodeFields((BadCursor)value, writer);
                    return;
                }
                if (value is Reset)
                {
                    WriteProperty(".tag", "reset", writer, enc.StringEncoder.Instance);
                    Reset.Encoder.EncodeFields((Reset)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetTeamEventsContinueError" />.</para>
        /// </summary>
        private class GetTeamEventsContinueErrorDecoder : enc.UnionDecoder<GetTeamEventsContinueError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetTeamEventsContinueError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetTeamEventsContinueError Create()
            {
                return new GetTeamEventsContinueError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GetTeamEventsContinueError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "bad_cursor":
                        return BadCursor.Decoder.DecodeFields(reader);
                    case "reset":
                        return Reset.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Bad cursor.</para>
        /// </summary>
        public sealed class BadCursor : GetTeamEventsContinueError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<BadCursor> Encoder = new BadCursorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<BadCursor> Decoder = new BadCursorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="BadCursor" /> class.</para>
            /// </summary>
            private BadCursor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of BadCursor</para>
            /// </summary>
            public static readonly BadCursor Instance = new BadCursor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="BadCursor" />.</para>
            /// </summary>
            private class BadCursorEncoder : enc.StructEncoder<BadCursor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(BadCursor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="BadCursor" />.</para>
            /// </summary>
            private class BadCursorDecoder : enc.StructDecoder<BadCursor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="BadCursor" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override BadCursor Create()
                {
                    return BadCursor.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Cursors are intended to be used quickly. Individual cursor values are
        /// normally valid for days, but in rare cases may be reset sooner.</para>
        /// <para>Cursor reset errors should be handled by fetching a new cursor from <see
        /// cref="Dropbox.Api.TeamLog.Routes.TeamLogTeamRoutes.GetEventsAsync" />.</para>
        /// <para>The associated value is the approximate timestamp of the most recent event
        /// returned by the cursor. This should be used as a resumption point when calling <see
        /// cref="Dropbox.Api.TeamLog.Routes.TeamLogTeamRoutes.GetEventsAsync" /> to obtain a
        /// new cursor.</para>
        /// </summary>
        public sealed class Reset : GetTeamEventsContinueError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Reset> Encoder = new ResetEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Reset> Decoder = new ResetDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Reset" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Reset(sys.DateTime value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Reset" /> class.</para>
            /// </summary>
            private Reset()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public sys.DateTime Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Reset" />.</para>
            /// </summary>
            private class ResetEncoder : enc.StructEncoder<Reset>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Reset value, enc.IJsonWriter writer)
                {
                    WriteProperty("reset", value.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Reset" />.</para>
            /// </summary>
            private class ResetDecoder : enc.StructDecoder<Reset>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Reset" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Reset Create()
                {
                    return new Reset();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(Reset value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "reset":
                            value.Value = enc.DateTimeDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : GetTeamEventsContinueError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
