//
// Copyright (c) Microsoft. All rights reserved.
// See https://aka.ms/csspeech/license201809 for the full license information.
//

#pragma once

#include <string>
#include <sstream>

#include "speechapi_cxx_properties.h"
#include <speechapi_cxx_string_helpers.h>
#include "speechapi_c_common.h"
#include "speechapi_c_speech_config.h"

namespace Microsoft {
namespace CognitiveServices {
namespace Speech {
namespace Translation {

class SpeechTranslationConfig final : public SpeechConfig
{
public:
    /// <summary>
    /// Creates an instance of the speech translation config with specified subscription key and region.
    /// </summary>
    /// <param name="subscription">The subscription key.</param>
    /// <param name="region">The region name (see the <a href="https://aka.ms/csspeech/region">region page</a>).</param>
    static std::shared_ptr<SpeechTranslationConfig> FromSubscription(const SPXSTRING& subscription, const SPXSTRING& region)
    {
        SPXSPEECHCONFIGHANDLE hconfig = SPXHANDLE_INVALID;
        SPX_THROW_ON_FAIL(speech_config_from_subscription(&hconfig, Utils::ToUTF8(subscription).c_str(), Utils::ToUTF8(region).c_str()));
        return std::shared_ptr<SpeechTranslationConfig>(new SpeechTranslationConfig(hconfig));
    }

    /// <summary>
    /// Creates an instance of the speech translation config with specified authorization token and region.
    /// </summary>
    /// <param name="authToken">The authorization token.</param>
    /// <param name="region">The region name (see the <a href="https://aka.ms/csspeech/region">region page</a>).</param>
    static std::shared_ptr<SpeechTranslationConfig> FromAuthorizationToken(const SPXSTRING& authToken, const SPXSTRING& region)
    {
        SPXSPEECHCONFIGHANDLE hconfig = SPXHANDLE_INVALID;
        SPX_THROW_ON_FAIL(speech_config_from_authorization_token(&hconfig, Utils::ToUTF8(authToken).c_str(), Utils::ToUTF8(region).c_str()));
        return std::shared_ptr<SpeechTranslationConfig>(new SpeechTranslationConfig(hconfig));
    }

    // <summary>
    /// Creates an instance of the speech translation config with specified endpoint and subscription.
    /// This method is intended only for users who use a non-standard service endpoint.
    /// Note: The query parameters specified in the endpoint URL are not changed, even if they are set by any other APIs.
    /// For example, if language is defined in uri as query parameter "language=de-DE", and also set by CreateSpeechRecognizer("en-US"),
    /// the language setting in uri takes precedence, and the effective language is "de-DE".
    /// Only the parameters that are not specified in the endpoint URL can be set by other APIs.
    /// </summary>
    /// <param name="endpoint">The service endpoint to connect to.</param>
    /// <param name="subscriptionKey">The subscription key.</param>
    static std::shared_ptr<SpeechTranslationConfig> FromEndpoint(const SPXSTRING& endpoint, const SPXSTRING& subscription)
    {
        SPXSPEECHCONFIGHANDLE hconfig = SPXHANDLE_INVALID;
        SPX_THROW_ON_FAIL(speech_config_from_endpoint(&hconfig, Utils::ToUTF8(endpoint).c_str(), Utils::ToUTF8(subscription).c_str()));
        return std::shared_ptr<SpeechTranslationConfig>(new SpeechTranslationConfig(hconfig));
    }

    /// <summary>
    /// Adds target language for translation.
    /// </summary>
    void AddTargetLanguage(const SPXSTRING& language)
    {
        if (!m_targetLanguages.empty())
            m_targetLanguages += ",";
        m_targetLanguages += Utils::ToUTF8(language);
        property_bag_set_string(m_propertybag, static_cast<int>(PropertyId::SpeechServiceConnection_TranslationToLanguages), nullptr, m_targetLanguages.c_str());
    }

    /// <summary>
    /// Gets target languages for translation.
    /// </summary>
    std::vector<SPXSTRING> GetTargetLanguages() const
    {
        std::vector<SPXSTRING> result;
        auto targetLanguges = Utils::ToUTF8(GetProperty(PropertyId::SpeechServiceConnection_TranslationToLanguages));
        if (targetLanguges.empty())
            return result;

        // Getting languages one by one.
        std::stringstream langaugeStream(targetLanguges);
        std::string token;
        while (std::getline(langaugeStream, token, ','))
        {
            result.push_back(Utils::ToSPXString(token));
        }
        return result;
    }

    /// <summary>
    /// Sets output voice name.
    /// </summary>
    void SetVoiceName(const SPXSTRING& voice)
    {
        property_bag_set_string(m_propertybag, static_cast<int>(PropertyId::SpeechServiceConnection_TranslationFeatures), nullptr, "textToSpeech");
        property_bag_set_string(m_propertybag, static_cast<int>(PropertyId::SpeechServiceConnection_TranslationVoice), nullptr, Utils::ToUTF8(voice).c_str());
    }

    /// <summary>
    /// Gets output voice name.
    /// </summary>
    SPXSTRING GetVoiceName() const
    {
        return GetProperty(PropertyId::SpeechServiceConnection_TranslationVoice);
    }

private:
    /// <summary>
    /// Internal constructor. Creates a new instance using the provided handle.
    /// </summary>
    explicit SpeechTranslationConfig(SPXSPEECHCONFIGHANDLE hconfig) : SpeechConfig(hconfig) { }

    DISABLE_COPY_AND_MOVE(SpeechTranslationConfig);

    std::string m_targetLanguages;
};

}}}}
