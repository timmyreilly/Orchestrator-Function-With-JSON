# Orchestrator-Function-With-JSON

A way to interact with a number of validator functions from one orchestrator. 

Sample JSON object to post to endopint: 

```json
{
	"DocumentDetails" : {
		"Name": "Tim",
		"Info" : "true",
		"Type" : 1 
	}, 
	
	"Signature": "timmyreilly",
	"SignatureTwo" : "timmyreilly",
	"Authority": "stamped",
	"Version" : 123
}
```