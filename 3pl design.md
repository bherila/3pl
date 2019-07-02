* CloudCheckoutController
  * Creates the shipment model and insert into the database
  * Validates shipment
  * use Helper class to do validation
* Azure Storage Queue
  * use BinaryFormatter or JSON to save item in Storage Queue as string (keep in mind Storage Queue size limits)
* Serverless Function to send to 3pl
  * Retrieve item from storage queue
  * HTTP request to REST API
  * Enqueue in 2nd queue to update tracking # after X time (use visibility date)

