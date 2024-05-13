// See https://aka.ms/new-console-template for more information
string longText = "Certainly! I can provide you with a high-level overview of the installation procedure for the Hucenrotia Robotic O2O system. However, please note that the installation process may vary depending on specific hardware configurations and requirements. It is always recommended to refer to the official documentation provided by Hucenrotia for detailed instructions. Here are the general steps involved in installing the O2O system:\r\n\r\n1. Unpack and inspect the O2O hardware: Begin by unpacking the O2O system and checking all the components to ensure they are in good condition.\r\n\r\n2. Assemble the O2O robot: Follow the assembly instructions provided by Hucenrotia to properly assemble the O2O robot. This may involve attaching different modules, such as the base, torso, arms, and head, as well as connecting the necessary cables and sensors.\r\n\r\n3. Connect the power supply: Plug in the power supply to the O2O robot and ensure it is securely connected.\r\n\r\n4. Set up the control system: Install the necessary software and drivers required for controlling the O2O robot. This may involve installing the robot operating system (ROS) and any other specific software packages provided by Hucenrotia.\r\n\r\n5. Calibrate the robot: Perform the calibration process to ensure the O2O robot's sensors and joints are properly aligned and calibrated. This may involve following specific calibration procedures provided by Hucenrotia.\r\n\r\nd. Test the robot: Once the installation and calibration are complete, conduct initial tests to ensure that the O2O robot is functioning correctly. This may involve testing the robot's movement, sensors, and any other specific functionalities.\r\n\r\nIt is essential to refer to the official documentation and guidelines provided by Hucenrotia for a detailed and accurate installation process. This will ensure that the installation is performed correctly and safely. "+ 
"Certainly! I can provide you with a high-level overview of the installation procedure for the Hucenrotia Robotic O2O system. However, please note that the installation process may vary depending on specific hardware configurations and requirements. It is always recommended to refer to the official documentation provided by Hucenrotia for detailed instructions. Here are the general steps involved in installing the O2O system:\r\n\r\n1. Unpack and inspect the O2O hardware: Begin by unpacking the O2O system and checking all the components to ensure they are in good condition.\r\n\r\n2. Assemble the O2O robot: Follow the assembly instructions provided by Hucenrotia to properly assemble the O2O robot. This may involve attaching different modules, such as the base, torso, arms, and head, as well as connecting the necessary cables and sensors.\r\n\r\n3. Connect the power supply: Plug in the power supply to the O2O robot and ensure it is securely connected.\r\n\r\n4. Set up the control system: Install the necessary software and drivers required for controlling the O2O robot. This may involve installing the robot operating system (ROS) and any other specific software packages provided by Hucenrotia.\r\n\r\n5. Calibrate the robot: Perform the calibration process to ensure the O2O robot's sensors and joints are properly aligned and calibrated. This may involve following specific calibration procedures provided by Hucenrotia.\r\n\r\n60. Test the robot: Once the installation and calibration are complete, conduct initial tests to ensure that the O2O robot is functioning correctly. This may involve testing the robot's movement, sensors, and any other specific functionalities.\r\n\r\nIt is essential to refer to the official documentation and guidelines provided by Hucenrotia for a detailed and accurate installation process. This will ensure that the installation is performed correctly and safely.";

List<string> SplitTextByMaxChars(string longText, int maxChars = 5000)
{
    List<string> textList = new List<string>();
    if (maxChars < longText.Length)
    {
        int rest_index = longText.Length;
        while (rest_index > maxChars)
        {
            int count = Math.Min(maxChars, rest_index);
            int lastPeriod = longText.LastIndexOf('.', count, count) + 1;
            int templastperiode = lastPeriod - 2;
            char c = 'u';

            do
            {
                c = longText[templastperiode];
                Console.WriteLine(c);
                if (char.IsDigit(c) || char.IsLetter(c))
                { 
                    lastPeriod = templastperiode;
                    templastperiode--;

                }
                else { break; }
            } while (char.IsDigit(c) || char.IsLetter(c));

            string x = longText.Substring(0, lastPeriod).Trim();
            textList.Add(longText.Substring(0, lastPeriod).Trim());
            longText = longText.Substring((lastPeriod), (longText.Length - lastPeriod)).Trim();
            rest_index -= lastPeriod;
        }
    }
    textList.Add(longText);
    return textList;
}
List<string> respon_msgs = SplitTextByMaxChars(longText, 1500);
foreach (string msg in respon_msgs)
{
    Console.WriteLine(msg);
    Console.WriteLine("\n new \n");

}

