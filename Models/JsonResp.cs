namespace dot_net_core_webapi_lesson.Models {

    public class JsonResp {

        public int Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public object Error { get; set; }

        public JsonResp() {}
    }
}