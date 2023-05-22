# Phone Validation API Example

This is a simple C# project that demonstrates how to use the Phone Validation API to validate a phone number and email address. It makes an HTTP request to the API endpoint and processes the response.

## Introduction

The Phone Validation API is a service that allows you to validate phone numbers and email addresses. It provides information about the phone number, such as the carrier name, line type, SMS gateway address, MMS gateway address, and whether the number is wireless.

This project demonstrates how to use the Phone Validation API by making an HTTP request to the API endpoint and processing the response.

Please note that before using this API, you need to sign up on the main website and obtain an API key by providing your email address. Make sure to keep your API key secure and do not share it publicly.

## Prerequisites

To run this project, you need the following prerequisites:

- .NET Framework or .NET Core installed on your machine
- Visual Studio or any other C# IDE

## Getting Started

To get started with this project, follow these steps:

1. Sign up on the [Phone Validation API website](https://phonevalidator.xyz) using your email address.
2. Obtain your API key from the website.
3. Clone the repository or download the project files to your local machine.
4. Open the project in your preferred C# IDE.
5. Replace the placeholders in the code (`'xxxxxxxxxx'` and `'xxx@x.com'`) with the actual phone number and email address you want to validate.
6. Build and run the project.

## Usage

When you run the project, it will make an HTTP request to the Phone Validation API with the provided phone number and email address. The API will validate the input and return a JSON response with the following information about the validated phone number:

- `phone_number`: The validated phone number.
- `carrier_name`: The name of the carrier associated with the phone number.
- `line_type`: The type of phone line (e.g., Mobile, Landline).
- `sms_gateway`: The SMS gateway address for the phone number.
- `mms_gateway`: The MMS gateway address for the phone number.
- `wireless`: Indicates whether the phone number is wireless (yes/no).

Example Response:

```json
{
 "phone_number": "12012802262",
 "carrier_name": "Verizon Wireless",
 "line_type": "Mobile",
 "sms_gateway": "2012802262@vtext.com",
 "mms_gateway": "2012802262@vzwpix.com",
 "wireless": "yes"
}



## Troubleshooting

If you encounter any issues while running the project or making the HTTP request, make sure you have a stable internet connection. Additionally, double-check that the provided phone number and email address are correct.

If the API endpoint or its response format has changed, you may need to update the code accordingly.

## License

This project is licensed under the [MIT License](LICENSE).

Feel free to use and modify the code as per your requirements.

## Resources

- [Phone Validator API Documentation](https://phonevalidator.xyz/file/api.pdf)
- [Phone Validator API Signup](https://phonevalidator.xyz/)
