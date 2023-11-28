from profanity_check import predict, predict_prob

def contains_profanity(text):
    return bool(predict([text])[0])

def profanity_prob(text):
    prob = predict_prob([text])[0]
    return round(prob, 2)
