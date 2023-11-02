namespace Modbus.Message
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// 
    /// </summary>
    public class SlaveExceptionResponse : AbstractModbusMessage, IModbusMessage
    {
        private static readonly Dictionary<byte, string> _exceptionMessages = CreateExceptionMessages();

        /// <summary>
        /// 
        /// </summary>
        public SlaveExceptionResponse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="slaveAddress"></param>
        /// <param name="functionCode"></param>
        /// <param name="exceptionCode"></param>
        public SlaveExceptionResponse(byte slaveAddress, byte functionCode, byte exceptionCode)
            : base(slaveAddress, functionCode)
        {
            SlaveExceptionCode = exceptionCode;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int MinimumFrameSize
        {
            get { return 3; }
        }

        /// <summary>
        /// 
        /// </summary>
        public byte SlaveExceptionCode
        {
            get { return MessageImpl.ExceptionCode.Value; }
            set { MessageImpl.ExceptionCode = value; }
        }

        /// <summary>
        ///     Returns a <see cref="T:System.String"></see> that represents the current <see cref="T:System.Object"></see>.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String"></see> that represents the current <see cref="T:System.Object"></see>.
        /// </returns>
        public override string ToString()
        {
            string message = _exceptionMessages.ContainsKey(SlaveExceptionCode)
                ? _exceptionMessages[SlaveExceptionCode]
                : ModbusResource.Unknown;
            return String.Format(CultureInfo.InvariantCulture, ModbusResource.SlaveExceptionResponseFormat,
                Environment.NewLine, FunctionCode, SlaveExceptionCode, message);
        }

        internal static Dictionary<byte, string> CreateExceptionMessages()
        {
            Dictionary<byte, string> messages = new Dictionary<byte, string>(9);

            messages.Add(1, ModbusResource.IllegalFunction);
            messages.Add(2, ModbusResource.IllegalDataAddress);
            messages.Add(3, ModbusResource.IllegalDataValue);
            messages.Add(4, ModbusResource.SlaveDeviceFailure);
            messages.Add(5, ModbusResource.Acknowlege);
            messages.Add(6, ModbusResource.SlaveDeviceBusy);
            messages.Add(8, ModbusResource.MemoryParityError);
            messages.Add(10, ModbusResource.GatewayPathUnavailable);
            messages.Add(11, ModbusResource.GatewayTargetDeviceFailedToRespond);

            return messages;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frame"></param>
        protected override void InitializeUnique(byte[] frame)
        {
            if (FunctionCode <= Modbus.ExceptionOffset)
                throw new FormatException(ModbusResource.SlaveExceptionResponseInvalidFunctionCode);

            SlaveExceptionCode = frame[2];
        }
    }
}
