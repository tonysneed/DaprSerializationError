# Dapr Serialization Error Reproduction

**Reference**: [How-To: Publish a message and subscribe to a topic](https://docs.dapr.io/developing-applications/building-blocks/pubsub/howto-publish-subscribe/)

1. Run Dapr.
    ```
    dapr run --app-id my-subscriber --app-port 5000 -- dotnet run
    ```
2. Publish topic.
    ```
    dapr publish --publish-app-id my-subscriber --pubsub pubsub --topic bar --data '{"data":"bar"}'
    ```

**Error**:

time="2021-03-12T20:58:14.6009483-06:00" level=warning msg="retriable error returned from app while processing pub/sub event 075765bc-a508-4109-b554-2c8c85563a98: {\"type\":\"https://tools.ietf.org/html/rfc7231#section-6.5.1\",\"title\":\"One or more validation errors occurred.\",\"status\":400,\"traceId\":\"00-a4a3575027ba11089391e6dc9a280cb4-4234020d36260544-01\",\"errors\":{\"$\":[\"The JSON value could not be converted to Subscriber.Foo. Path: $ | LineNumber: 0 | BytePositionInLine: 24.\"]}}. status code returned: 400" app_id=my-subscriber instance=ANTHONYSNEE0987 scope=dapr.runtime type=log ver=1.0.1
