# WebService
A demo of a soap web API to get date and time  of diferent time zones.

You can try a method with a parameter by calling https://localhost:44391/TimeService.asmx using Postman with the following content:

<?xml version="1.0" encoding="utf-8"?>
<soap12:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap12="http://www.w3.org/2003/05/soap-envelope">
  <soap12:Body>
    <CurrentTimeByZone xmlns="http://tempuri.org/">
      <destinationTimeZoneId>Pacific SA Standard Time</destinationTimeZoneId>
    </CurrentTimeByZone>
  </soap12:Body>
</soap12:Envelope>
