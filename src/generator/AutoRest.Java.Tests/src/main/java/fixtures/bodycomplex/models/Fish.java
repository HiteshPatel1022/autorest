/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodycomplex.models;

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonTypeInfo;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonSubTypes;

/**
 * The Fish model.
 */
@JsonTypeInfo(use = JsonTypeInfo.Id.NAME, include = JsonTypeInfo.As.PROPERTY, property = "fishtype")
@JsonTypeName("Fish")
@JsonSubTypes({
    @JsonSubTypes.Type(name = "salmon", value = Salmon.class),
    @JsonSubTypes.Type(name = "shark", value = Shark.class)
})
public class Fish {
    /**
     * The species property.
     */
    @JsonProperty(value = "species")
    private String species;

    /**
     * The length property.
     */
    @JsonProperty(value = "length", required = true)
    private double length;

    /**
     * The siblings property.
     */
    @JsonProperty(value = "siblings")
    private List<Fish> siblings;

    /**
     * Get the species value.
     *
     * @return the species value
     */
    public String species() {
        return this.species;
    }

    /**
     * Set the species value.
     *
     * @param species the species value to set
     * @return the Fish object itself.
     */
    public Fish withSpecies(String species) {
        this.species = species;
        return this;
    }

    /**
     * Get the length value.
     *
     * @return the length value
     */
    public double length() {
        return this.length;
    }

    /**
     * Set the length value.
     *
     * @param length the length value to set
     * @return the Fish object itself.
     */
    public Fish withLength(double length) {
        this.length = length;
        return this;
    }

    /**
     * Get the siblings value.
     *
     * @return the siblings value
     */
    public List<Fish> siblings() {
        return this.siblings;
    }

    /**
     * Set the siblings value.
     *
     * @param siblings the siblings value to set
     * @return the Fish object itself.
     */
    public Fish withSiblings(List<Fish> siblings) {
        this.siblings = siblings;
        return this;
    }

}
